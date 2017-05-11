using KaffePTCloud.Core.Models;
using System.Net.Mail;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace KaffePTCloud.Core.Controllers
{
    public class HomeController : SurfaceController
    {
        public ActionResult IntroSection() => PartialView("~/Views/Partials/Home/Intro.cshtml");

        public ActionResult TeaserSection() => PartialView("~/Views/Partials/Home/Teasers.cshtml");

        public ActionResult ServicesSection() => PartialView("~/Views/Partials/Home/Services.cshtml");

        public ActionResult ReviewSection() => PartialView("~/Views/Partials/Home/Reviews.cshtml");

        public ActionResult BlogPostSection() => PartialView("~/Views/Partials/Home/BlogPosts.cshtml");

        public ActionResult ContactFormSection() => PartialView("~/Views/Partials/Home/ContactForm.cshtml");

        public ActionResult ContactSection() => View("~/Views/Contact.cshtml");

        public ActionResult Submit(ContactFormViewModel model)
        {

            if (ModelState.IsValid)
            {
                SendEmail(model);
                TempData["ContactSuccess"] = true;
                //           messageSent = true;
                TempData["Message"] = "messageSent";
                ModelState.Clear();

                return RedirectToAction("ContactSection");
                //return CurrentUmbracoPage();
            }
            return CurrentUmbracoPage();
        }

        private void SendEmail(ContactFormViewModel model)
        {
            MailMessage message = new MailMessage(model.Email, "info@cafemania.com");
            message.Subject = string.Format("Cafemanina visitor mail {0} - {1}", model.Name, model.Email);
            message.Body = model.Message + @"
Phonenumber: " + model.Phone;
            SmtpClient client = new SmtpClient("127.0.0.1", 25);

            client.Send(message);
        }
    }
}