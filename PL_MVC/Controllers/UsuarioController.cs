using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using ML;
using System.Drawing;

namespace PL_MVC.Controllers
{
    public class UsuarioController : Controller
    {

        // GET: Usuario
        public ActionResult Index()
        {
            ML.Usuario usuario = new ML.Usuario();
            usuario.ROL = new ML.Rol();
            ML.Result result = BL.Usuario.GetAllEF(usuario);
            ML.Result resultRol = new ML.Result();
            resultRol = BL.Rol.GetAllEF();

            if (result.Correct == true)
            {
                usuario.Usuarios = result.Objects;
                usuario.ROL.Roles = resultRol.Objects;
            }
            else
            {
                ViewBag.Message = "Algo salioi mal" + result.ErrorMessage;
            }
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Index(ML.Usuario usuario)
        {
            ML.Result resultRol = new ML.Result();
            resultRol = BL.Rol.GetAllEF();
            ML.Result result = BL.Usuario.GetAllEF(usuario);
            usuario.ROL = new ML.Rol();
            
            if (result.Correct == true)
            {
                usuario.Usuarios = result.Objects;
                usuario.ROL.Roles = resultRol.Objects;
            }
            else
            {
                ViewBag.Message = "Algo salioi mal" + result.ErrorMessage;
                usuario.ROL.Roles = resultRol.Objects;
            }
            return View(usuario);
        }


        [HttpGet]
        public ActionResult Form(int? IdUsuario)
        {
            ML.Usuario usuario = new ML.Usuario();
            usuario.Direccion = new ML.Direccion();
            usuario.Direccion.Colonia = new ML.Colonia();
            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
            usuario.ROL = new ML.Rol();
            ML.Result resultRol = BL.Rol.GetAllEF();
            ML.Result resultPais = BL.Pais.GetAllEF();

            if (IdUsuario == null)
            {
                usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;
                usuario.ROL.Roles = resultRol.Objects;
                return View(usuario);
            }
            else
            {
                //Update
                ML.Result result = BL.Usuario.GetByIdEF(IdUsuario.Value);

                if (result.Correct)
                {
                    usuario = (ML.Usuario)result.Object;
                    usuario.ROL.Roles = resultRol.Objects;
                    usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;

                    ML.Result resultEstado = BL.Estado.GetByIdPais(usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais);
                    usuario.Direccion.Colonia.Municipio.Estado.Estados = resultEstado.Objects;

                    ML.Result resultMunicipio = BL.Municipio.GetByIdEstado(usuario.Direccion.Colonia.Municipio.Estado.IdEstado);
                    usuario.Direccion.Colonia.Municipio.Municipios = resultMunicipio.Objects;

                    ML.Result resultColonia = BL.Colonia.GetByIdMunicipio(usuario.Direccion.Colonia.Municipio.IdMunicipio);
                    usuario.Direccion.Colonia.Colonias = resultColonia.Objects;

                    ML.Result resultDireccion = BL.Direccion.GetByIdColonia(usuario.Direccion.Colonia.IdColonia);
                    usuario.Direccion.Direcciones = resultDireccion.Objects;

                    
                }
                else
                {
                    ViewBag.Message = "No existe";
                }

                return View(usuario);
            }

        }


        [HttpPost]
        public ActionResult Form(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            //HttpPostedFileBase file = Request.Files["ImagenData"];
            //if (file.ContentLength > 0)
            //{
            //    usuario.Imagen = ConvertToByte(file);
            //}
            if (usuario.IdUsuario == 0)
            {
                
                //Add
                
                result = BL.Usuario.AddEF(usuario);


                if (result.Correct)
                {
                    ViewBag.Message = "Se ha registrado exitosamente";
                    return PartialView("Modal");
                }
                else
                {
                    ViewBag.Message = "Ha ocurrido un error" + result.ErrorMessage;
                    return PartialView("Modal");
                }
            }
            else
            {
                //Update
                result = BL.Usuario.UpdateEF(usuario);

                if (result.Correct)
                {
                    ViewBag.Message = "Se ha actualizado exitosamente";
                    return PartialView("Modal");
                }
                else
                {
                    ViewBag.Message = "Ha ocurrido un error";
                    return PartialView("Modal");
                }
            }

        }

        [HttpGet]
        public ActionResult Delete(int? IdUsuario)
        {
            ML.Result result = new ML.Result();

            if (IdUsuario == null)
            {
                ViewBag.Message = "Algo ocurrio";
                return PartialView("Modal");
            }
            else
            {

                result = BL.Usuario.DeleteEF(IdUsuario.Value);
                if (result.Correct)
                {
                    ViewBag.Message = "Se elimino correctamente";
                    return PartialView("Modal");
                }

                else
                {
                    ViewBag.Message = "Algo ocurrio" + result.ErrorMessage;
                    return PartialView("Modal");
                }
            }
        }


        public JsonResult GetEstado(int IdPais)
        {


            var result = BL.Estado.GetByIdPais(IdPais);


            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetMunicipio(int IdEstado)
        {


            var result = BL.Municipio.GetByIdEstado(IdEstado);


            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetColonia(int IdMunicipio)
        {
            var result = BL.Colonia.GetByIdMunicipio(IdMunicipio);

            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }

        //public byte[] ConvertToByte(HttpPostedFileBase Imagen)
        //{
        //    byte[] data = null;
            

        //    System.IO.BinaryReader reader = new System.IO.BinaryReader(Imagen.InputStream);
        //    data = reader.ReadBytes((int)Imagen.ContentLength);

        //    return data;
        //}

    }
}



//ML.Usuario lista = new ML.Usuario();

//    lista.Usuarios = new List<object>();

//    foreach (ML.Usuario usuario in result.Objects)
//    {
//        lista.Usuarios.Add(usuario);
//    }

//return View(lista.Usuarios);



//List<ML.Usuario> query;
//using (DAguirreProgramacionNCapasEntities context = new DAguirreProgramacionNCapasEntities())
//{
//    query = (from u in context.Usuarios
//                 select new ML.Usuario
//                 {
//                     IdUsuario = u.IdUsuario,
//                     Nombre = u.Nombre,
//                     ApellidoPaterno = u.ApellidoPaterno,
//                     ApellidoMaterno = u.ApellidoMaterno,
//                     Sexo = u.Sexo,
//                     Email = u.Email,
//                     Password = u.Password,
//                     UserName = u.UserName,
//                     Telefono = u.Telefono,
//                     Celular = u.Celular,
//                     CURP = u.CURP,
//                     IdRol = u.Rol.IdRol,
//                     FechaDeNacimiento = u.FechaDeNacimiento
//                 }).ToList();
//}
//return View(query);
