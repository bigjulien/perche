/*
 * Crée par SharpDevelop.
 * Utilisateur: Julien
 * Date: 12/01/2016
 * Heure: 16:57
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

using WComp.Beans;

namespace DefaultNamespace
{
	/// <summary>
	/// Description of Container1.
	/// </summary>
	public class Container1 : System.Windows.Forms.Form
	{
        [BeanDesignLocation(72,200)]
        private WComp.MPMS.Light_Sensor light_Sensor1;
        [BeanDesignLocation(496,200)]
        private WComp.Beans.Console console1;
        [BeanDesignLocation(360,200)]
        private WComp.BasicBeans.ToString toString1;
		public Container1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// The InitializeBeans() call is required for WComp.NET designer support.
			//
			InitializeBeans();
			
			//
			// TODO: Add constructor code after the InitializeBeans() call.
			//
		}
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new Container1());
		}
		
		#region WComp.NET designer generated code
		/// <summary>
		/// This method is required for WComp.NET designer support.
		/// Do not change the method contents inside the source code editor.
		/// The WComp.NET designer might not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent() {
            // 
            // perche
            // 
            this.Text = "SharpWComp static application";
        }
		
		/// <summary>
		/// This method is required for WComp.NET designer support.
		/// Do not change the method contents inside the source code editor.
		/// The WComp.NET designer might not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeBeans() {
            this.light_Sensor1 = new WComp.MPMS.Light_Sensor();
            this.console1 = new WComp.Beans.Console();
            this.toString1 = new WComp.BasicBeans.ToString();
            // 
            // light_Sensor1
            // 
            this.light_Sensor1.RefreshVal = 25;
            this.light_Sensor1.Value = -1;
            this.light_Sensor1.TypeConvert = null;
            this.light_Sensor1.configuration = WComp.MPMS.Configuration.Auto;
            this.light_Sensor1.Port = 0;
            this.light_Sensor1.Type = "Light_Sensor";
            // 
            // Event dispatching
            // 
            this.toString1.Output += new WComp.Beans.StringEventHandler(this.console1.ConsoleInfo);
            this.light_Sensor1.ValueChanged += new WComp.MPMS.GenericSensor<double>.IntValueEventHandler(this.toString1.Input);
        }
		#endregion
	}
}
