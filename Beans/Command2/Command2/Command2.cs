/*
 * Crée par SharpDevelop.
 * Utilisateur: Julien
 * Date: 19/01/2016
 * Heure: 15:27
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using WComp.Beans;
using System.Diagnostics;

namespace WComp.Beans
{
	/// <summary>
	/// This is a sample bean, which has an integer evented property and a method.
	/// 
	/// Notes: for beans creating threads, the IThreadCreator interface should be implemented,
	/// 	providing a cleanup method should be implemented and named `Stop()'.
	/// For proxy beans, the IProxyBean interface should  be implemented,
	/// 	providing the IsConnected property, allowing the connection status to be drawn in
	/// 	the AddIn's graphical designer.
	/// 
	/// Several classes can be defined or used by a Bean, but only the class with the
	/// [Bean] attribute will be available in WComp. Its ports will be all public methods,
	/// events and properties definied in that class.
	/// </summary>
	[Bean(Category="Command")]
	public class Command
	{
		/// <summary>
		/// Fill in private attributes here.
		/// </summary>
		private string strcomm;

		/// <summary>
		/// Set the command
		/// </summary>
		public string StrComm {
			get { return strcomm; }
			set {
				strcomm = value;
			}
		}

		/// <summary>
		/// Launch the command
		/// </summary>
		public void SendCommand() {
			Process proc = new Process();
			proc.StartInfo.FileName = "/bin/bash";
			proc.StartInfo.Arguments = "-c raspistill -o image.jpg";
			proc.StartInfo.UseShellExecute = false; 
			proc.StartInfo.RedirectStandardOutput = true;
			proc.Start();
		}
	}
}
