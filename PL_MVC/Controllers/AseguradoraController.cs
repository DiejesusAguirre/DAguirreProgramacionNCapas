using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class AseguradoraController : Controller
    {
        // GET: Aseguradora
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Result result = BL.Aseguradora.GetAllEF();
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            if (result.Correct)
            {
                aseguradora.Aseguradoras = result.Objects;
            }
            else
            {
                ViewBag.Message = "Algo salioi mal";
            }
            return View(aseguradora);
        }

        [HttpGet]
        public ActionResult Form(int? IdAseguradora)
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            ML.Usuario usuario = new ML.Usuario();
            ML.Result resultAseguradora = new ML.Result();
            aseguradora.Usuario = new ML.Usuario();
            resultAseguradora = BL.Usuario.GetAllEF(usuario);



            if (IdAseguradora == null)
            {
                aseguradora.Usuario.Usuarios = resultAseguradora.Objects;
                return View(aseguradora);
            }
            else
            {
                //Update
                ML.Result result = BL.Aseguradora.GetByIdEF(IdAseguradora.Value);

                if (result.Correct)
                {
                    aseguradora = (ML.Aseguradora)result.Object;
                }
                else
                {
                    ViewBag.Message = "No existe";
                }
            }
            aseguradora.Usuario.Usuarios = resultAseguradora.Objects;
            return View(aseguradora);
        }

        [HttpPost]
        public ActionResult Form(ML.Aseguradora aseguradora)
        {
            if (aseguradora.IdAseguradora == 0)
            {
                //Add
                ML.Result result = new ML.Result();
                result = BL.Aseguradora.AddEF(aseguradora);

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
                ML.Result result = BL.Aseguradora.UpdateEF(aseguradora);

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
        public ActionResult Delete(int? IdAseguradora)
        {
            ML.Result result = new ML.Result();

            if (IdAseguradora == null)
            {
                ViewBag.Message = "Algo ocurrio";
                return PartialView("Modal");
            }
            else
            {

                result = BL.Aseguradora.DeleteEF(IdAseguradora.Value);
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

    }
}