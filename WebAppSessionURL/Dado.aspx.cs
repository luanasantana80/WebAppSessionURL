using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSessionURL
{
    public partial class Dado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Nome_Pessoa"] != null)
                {
                    Label1.Text = Session["Nome_Pessoa"].ToString();
                }
                if (Session["Endereco_Pessoa"] != null)
                {
                    Label2.Text = Session["Endereco_Pessoa"].ToString();
                }
                if (Session["Idade_Pessoa"] != null)
                {
                    Label3.Text = Session["Idade_Pessoa"].ToString();
                }
                if (Session["Idade_Pessoa"] != null)
                {
                    Label3.Text = Session["Idade_Pessoa"].ToString();
                }
                if (Session["Telefone_Pessoa"] != null)
                {
                    Label4.Text = Session["Telefone_Pessoa"].ToString();
                }
                if(Request.QueryString["Nome"]!= null)
                {
                    Label1.Text = Request.QueryString["Nome"].ToString();
                }
                if (Request.QueryString["Endereco"] != null)
                {
                    Label2.Text = Request.QueryString["Endereco"].ToString();
                }
                if (Request.QueryString["Idade"] != null)
                {
                    Label3.Text = Request.QueryString["Idade"].ToString();
                }
                if (Request.QueryString["Telefone"] != null)
                {
                    Label4.Text = Request.QueryString["Telefone"].ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.RemoveAll();
            Response.Redirect("WebForm1.aspx", true);
        }
    }
}