﻿/*
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
        [BeanDesignLocation(0,120)]
        private WComp.MPMS.Light_Sensor light_Sensor1;
        [BeanDesignLocation(496,120)]
        private WComp.Beans.Console console1;
        [BeanDesignLocation(248,120)]
        private WComp.BasicBeans.Threshold threshold1;
        [BeanDesignLocation(128,120)]
        private WComp.BasicBeans.ToString toString2;
        [BeanDesignLocation(368,120)]
        private WComp.BasicBeans.ToString toString2Copy;
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
            // perche2
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
            this.threshold1 = new WComp.BasicBeans.Threshold();
            this.toString2 = new WComp.BasicBeans.ToString();
            this.toString2Copy = new WComp.BasicBeans.ToString();
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
            // threshold1
            // 
            this.threshold1.Value = null;
            this.threshold1.ThresholdValue = 50;
            this.threshold1.Inverted = true;
            this.threshold1.Min = 1.7976931348623157E+308;
            this.threshold1.Max = -1.7976931348623157E+308;
            // 
            // Event dispatching
            // 
            this.light_Sensor1.ValueChanged += new WComp.MPMS.GenericSensor<double>.IntValueEventHandler(this.toString2.Input);
            this.toString2.Output += new WComp.Beans.StringEventHandler(this.@__toString2_to_threshold1_0);
            this.threshold1.ThresholdReachedBool += new WComp.Beans.BoolEventHandler(this.toString2Copy.Input);
            this.toString2Copy.Output += new WComp.Beans.StringEventHandler(this.console1.ConsoleInfo);
        }

		private void @__toString2_to_threshold1_0(string s) {
            this.threshold1.Value = s;
        }

		private void @__toString2_to_threshold1_0(string s) {
            this.threshold1.Value = s;
        }

		private void @__toString2_to_threshold1_0(string s) {
            this.threshold1.Value = s;
        }

		private void @__toString3_to_threshold2_1(string s) {
            this.threshold2.Value = s;
        }
		#endregion
	}
}
