using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PodLynk.Models;
using WebMatrix.WebData;
using PodLynk.Filters;

namespace PodLynk.Controllers
{
    [InitializeSimpleMembership]
    public class ProjectController : Controller
    {
        //
        // GET: /Project/
        [Authorize]
        public ActionResult Index()
        {
            List<Projects> post = new List<Projects>();
            using (var context = new UsersContext())
            {
                var Job = context.Projects.Where(t => t.UserID == WebSecurity.CurrentUserId);
                if (Job.Any())
                {
                    foreach (var j in Job)
                    {
                        Projects model = new Projects();
                        model.Id = j.Id;
                        model.ProjectTitle = j.ProjectTitle;
                        model.CreatedAt = j.CreatedAt;
                        model.UpdatedAt = j.UpdatedAt;
                        model.UserID = j.UserID;


                        post.Add(model);
                    }
                }
                else
                {
                    post = new List<Projects>();
                }

            }



            return View(post);
        }

        public ActionResult Create(int ProjectID = 0)
        {
            return View();
        }

    }
}
