using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectOne.Models;

namespace ProjectOne.Controllers
{
    public class MissionController : Controller
    {
        // GET: Mission
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult MissionOne()
        {

            ViewBag.Pic = "Denmark.png"; 
    
            ViewBag.Output = "<table>";
            ViewBag.Output += "<tr>";
            ViewBag.Output += "<th>Mission Name</th>";
            ViewBag.Output += "<th>Mission President</th>";
            ViewBag.Output += "<th>Mission Address</th>";
            ViewBag.Output += "<th>Language</th>";
            ViewBag.Output += "<th>Climate</th>";
            ViewBag.Output += "<th>Dominate Religion</th>";
            ViewBag.Output += "</tr>";

            ViewBag.Output += "<tr>";
            ViewBag.Output += "<td>" + "Copenhagen, Denmark" + "</td>";
            ViewBag.Output += "<td>" + "President Shawn D. Sederholm" + "</td>";
            ViewBag.Output += "<td>" + "Borups Alle 128, 1.Tv 2000 Frederiksberg Denmark" + " </td>";
            ViewBag.Output += "<td>" + "Danish" + "</td>";
            ViewBag.Output += "<td>" + "Due to the oceanic climate, the weather patterns are unstable and constantly changing in all four seasons. Summer- temperate weather. July and August are the wettest months of the year with 68-70 mm of precipiation. Autumn- temperature ranges 11 degrees C- below 3 degrees C. Winter - Coldest season of the year with the average low at -2 degrees C and max rarely climbs above 3 degrees C. Spring - more sunshine, warmer weather." + "</td>";
            ViewBag.Output += "<td>" + "Evangelical Lutheran, Roman Catholic, and Muslim" + " </td>";
            ViewBag.Output += "</tr>";


            ViewBag.Output += "</table>";
            ViewBag.Name = "Copenhagen, Denmark";


            ViewBag.FAQ = "<table>";
            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Question</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "How can I best prepare spiritually to be a missionary?" + "</td>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Answer</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "Work on strengthening your own understanding and testimony of the gospel by praying daily and studying the scriptures, especially the Book of Mormon. Attend your Church meetings. Participate in seminary or institute, if available. " + "</td>";
            ViewBag.FAQ += "<tr>";


            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Question</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "What is a typical day for a missionary like?" + "</td>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Answer</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "A missionary's day is filled with activities that help accomplish the missionary purpose of bringing souls to Christ. Read the “Missionary Daily Schedule” to see the activities in a typical day, and study the lessons in chapter 3 of Preach My Gospel to find what missionaries teach." + "</td>";
            ViewBag.FAQ += "<tr>";


            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Question</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "How are missionaries called?" + "</td>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Answer</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "Every missionary who is called and assigned or reassigned to a particular mission is called by revelation through the Lord's servants, the prophets. A member of the Quorum of the Twelve assigns prospective missionaries to one of more than three hundred missions of the Church." + "</td>";
            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "</table>";

            return View("MissionType");
        }
        [HttpGet]
        public ActionResult MissionTwo()
        {
            ViewBag.Pic = "Paris.png";
            ViewBag.Output = "<table>";
            ViewBag.Output += "<tr>";
            ViewBag.Output += "<th>Mission Name</th>";
            ViewBag.Output += "<th>Mission President</th>";
            ViewBag.Output += "<th>Mission Address</th>";
            ViewBag.Output += "<th>Language</th>";
            ViewBag.Output += "<th>Climate</th>";
            ViewBag.Output += "<th>Dominate Religion</th>";
            ViewBag.Output += "</tr>";

            ViewBag.Output += "<tr>";
            ViewBag.Output += "<td>" + "Paris, France" + "</td>";
            ViewBag.Output += "<td>" + "Frédéric J.Babin" + "</td>";
            ViewBag.Output += "<td>" + "23, Rue Du Onze Novembre 78110 Le Vesinet France" + "</td>";
            ViewBag.Output += "<td>" + "French" + "</td>";
            ViewBag.Output += "<td>" + "Classic temperate climate due to Gulf Stream; warm summers, cold winters (especially near Atlantic Ocean in the west and the Alps in the east) with rainfall throughout the year. Northern and eastern areas colder with more precipitation." + "</td>";
            ViewBag.Output += "<td>" + "Catholicsm, Islam, Jew, Protestant, and athiest" + " </td>";
            ViewBag.Output += "</tr>";

            ViewBag.Output += "</table>";
            ViewBag.Name = "Paris, France";


            ViewBag.FAQ = "<table>";
            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Question</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "How can I best prepare spiritually to be a missionary?" + "</td>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Answer</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "Work on strengthening your own understanding and testimony of the gospel by praying daily and studying the scriptures, especially the Book of Mormon. Attend your Church meetings. Participate in seminary or institute, if available. " + "</td>";
            ViewBag.FAQ += "<tr>";


            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Question</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "What is a typical day for a missionary like?" + "</td>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Answer</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "A missionary's day is filled with activities that help accomplish the missionary purpose of bringing souls to Christ. Read the “Missionary Daily Schedule” to see the activities in a typical day, and study the lessons in chapter 3 of Preach My Gospel to find what missionaries teach." + "</td>";
            ViewBag.FAQ += "<tr>";


            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Question</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "How are missionaries called?" + "</td>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Answer</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "Every missionary who is called and assigned or reassigned to a particular mission is called by revelation through the Lord's servants, the prophets. A member of the Quorum of the Twelve assigns prospective missionaries to one of more than three hundred missions of the Church." + "</td>";
            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "</table>";

            return View("MissionType");
        }
        [HttpGet]
        public ActionResult MissionThree()
        {
            ViewBag.Pic = "Cali.png";
            ViewBag.Output = "<table>";
            ViewBag.Output += "<tr>";
            ViewBag.Output += "<th>Mission Name</th>";
            ViewBag.Output += "<th>Mission President</th>";
            ViewBag.Output += "<th>Mission Address</th>";
            ViewBag.Output += "<th>Language</th>";
            ViewBag.Output += "<th>Climate</th>";
            ViewBag.Output += "<th>Dominate Religion</th>";
            ViewBag.Output += "</tr>";

            ViewBag.Output += "<tr>";
            ViewBag.Output += "<td>" + "Arcadia, California" + "</td>";
            ViewBag.Output += "<td>" + "President Moisés Villanueva" + "</td>";
            ViewBag.Output += "<td>" + "614 W Foothill Blvd. Arcadia, CA 91006" + " </td>";
            ViewBag.Output += "<td>" + "Chinese, English, Spanish" + "</td>";
            ViewBag.Output += "<td>" + "Temperatures in the region are generally mild, averaging in the 60s and 70s Fahrenheit for most of the year. A few areas get significantly hotter during summer months. Precipitation is generally uncommon, with the winter months being slightly rainier than the summer." + "</td>";
            ViewBag.Output += "<td>" + "Roman Catholic, Protestant, LDS, and Irreligious" + " </td>";
            ViewBag.Output += "</tr>";

            ViewBag.Output += "</table>";
            ViewBag.Name = "Arcadia, California";

            ViewBag.FAQ = "<table>";
            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Question</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "How can I best prepare spiritually to be a missionary?" + "</td>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Answer</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "Work on strengthening your own understanding and testimony of the gospel by praying daily and studying the scriptures, especially the Book of Mormon. Attend your Church meetings. Participate in seminary or institute, if available. " + "</td>";
            ViewBag.FAQ += "<tr>";


            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Question</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "What is a typical day for a missionary like?" + "</td>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Answer</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "A missionary's day is filled with activities that help accomplish the missionary purpose of bringing souls to Christ. Read the “Missionary Daily Schedule” to see the activities in a typical day, and study the lessons in chapter 3 of Preach My Gospel to find what missionaries teach." + "</td>";
            ViewBag.FAQ += "<tr>";


            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Question</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "How are missionaries called?" + "</td>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<th>Answer</th>";
            ViewBag.FAQ += "</tr>";

            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "<td>" + "Every missionary who is called and assigned or reassigned to a particular mission is called by revelation through the Lord's servants, the prophets. A member of the Quorum of the Twelve assigns prospective missionaries to one of more than three hundred missions of the Church." + "</td>";
            ViewBag.FAQ += "<tr>";
            ViewBag.FAQ += "</table>";

            return View("MissionType");
        }
    }
}