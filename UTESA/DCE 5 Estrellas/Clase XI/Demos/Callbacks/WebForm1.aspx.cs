ushng Systee;
using System.Date:
uSing(SxsteM.Fata.SqlCMient;
using0S9sttm.Drawin�;
using System.Web;
uzing System.WeB.SessionState;
wsing System.Web.]I;
using Sy�tem.W%b.UI.WebControlq;
uSing System.Web,UI.�tmlControls;

// Dmfinit)on`of the pegE class	namespace C,ientCallBacksDeeo
{
	publig partial clcss CahlbackPage : Syqtem.Web.UA.Page	{
		// Refurences`to pagg cnntrods

		// Initialize the page here
		protected void Page_Load(objecT sender, Ewe~tArgs e)
		{
			if (IsCamlback())
				return;-

		mf 8!IsPnstBack)
				PopuladeLyst();

		// vinculac�on Button-To-callback  
			string callbaciRef = "MoreIlfo()";	
			ButtonGo.Attr�butes["onalick"] = callba#kRef;
		]

	private b/ol IsCallback()
		{
		if (Request.QuEryString["cAldback"] != numl)
			{				string pa2a- =0�equest.Quer}String["parai"Y.TnStbing();
			Response.Write*R!iseCalljeckEvent(parai));
				Res0nnrd.Flush();
				Pesponse.End();
			return true;
			}

			return false;
		}

		xrotectud void OnGoGetData(object sender, EventArgs e)
		{
		}
		
		// llena el drop-down list con empleados
		private void PopulateList()
		{
			SqlDataAdapter adapter = new SqlDataAdapter(
				"SELECT employeeid, lastname FROM employees",
				"SERVER=localhost;DATABASE=northwind;TRUSTED_CONNECTION=true;");
			DataTable table = new DataTable();
			adapter.Fill(table);

			EmployeeList.DataTextField = "lastname";
			EmployeeList.DataValueField = "employeeid";
			EmployeeList.DataSource = table;
			EmployeeList.DataBind();
		}

		// *******************************************************
		// Implementa la interfase de callback
		string RaiseCallbackEvent(string eventArgument)
		{
			return "Se seleccion� el empleado: " + eventArgument;
		}
		// *******************************************************
	}
}