using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeeManager;

namespace BeeWebApp
{
    public partial class _Default : Page
    {
        List<Workerbee> workerBees = new List<Workerbee>();
        List<QueenBee> QueenBees = new List<QueenBee>();
        List<DroneBee> DroneBees = new List<DroneBee>();

        public _Default()
        {
            CreateObjectOfBees();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                BindData();

        }
        private void CreateObjectOfBees()
        {
            for (int i = 0; i < 10; i++)
            {
                Workerbee workerBee = new Workerbee()
                {
                    WorkerBeeId = i + 1
                };
                workerBees.Add(workerBee);

                QueenBee queenBee = new QueenBee()
                {
                    QueenBeeId = i + 1
                };
                QueenBees.Add(queenBee);

                DroneBee droneBee = new DroneBee()
                {
                    DroneBeeId = i + 1
                };
                DroneBees.Add(droneBee);
            }

        }

        private void BindData()
        {
            GridView1.DataSource = workerBees;
            GridView1.DataBind();

        }

        protected void update(object sender, EventArgs e)
        {
            Button update = sender as Button;
            if (update != null & !String.IsNullOrEmpty(update.CommandArgument))
            {
                int workerBeeId = int.Parse(update.CommandArgument);
                Random rnd = new Random();
                int randomNumber = rnd.Next(0, 100);
                Workerbee workerBee = workerBees.Where(obj => obj.WorkerBeeId == workerBeeId).FirstOrDefault();
                if (workerBee != null)
                    workerBee.Damage(randomNumber);

                BindData();
            }
        }
    }
}