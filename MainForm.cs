/*
 * Created by SharpDevelop.
 * User: Soner
 * Date: 24.08.2019
 * Time: 16:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Town_Of_Salem_İnfov2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button4Click(object sender, EventArgs e)
		{
			
			if (comboBox1.Text=="Investigator") 
	      {
	      	label1.Text="Investigator";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Mayor";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Consigliere";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.YellowGreen;
			label10.Text="Plaguebearer";
			label10.BackColor=Color.Black;
			label11.ForeColor=Color.Green;
			label11.Text="Tracker";
			label11.BackColor=Color.Black;

		
	      }
	      if (comboBox1.Text=="Lookout") 
	      {
	      	label1.Text="Lookout";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Witch";
	      	label2.ForeColor=Color.Purple;
	      	label3.Text="Forger";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.DarkViolet;
			label11.Text="Coven Leader";
			label11.BackColor=Color.Black;
	
	      }
	      if (comboBox1.Text=="Spy") 
	      {
	      	label1.Text="Spy";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Jailor";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Blackmailer";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.White;
			label11.Text="Guardian Angel";
			label11.BackColor=Color.Black;

		
	      }
	      if (comboBox1.Text=="Sheriff") 
	      {
	      	label1.Text="Sheriff";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Executioner";
	      	label2.ForeColor=Color.Gray;
	      	label3.Text="Werewolf";
	      	label3.ForeColor=Color.Brown;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.DarkViolet;
			label11.Text="Poisoner";
			label11.BackColor=Color.Black;

	      }
	      if (comboBox1.Text=="Jailor") 
	      {
	      	label1.Text="Spy";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Jailor";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Blackmailer";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.White;
			label11.Text="Guardian Angel";
			label11.BackColor=Color.Black;

	      }
	      if (comboBox1.Text=="Vampire Hunter") 
	      {
	      	label1.Text="Vampire Hunter";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Survivor";
	      	label2.ForeColor=Color.Gold;
	      	label3.Text="Amnesiac";
	      	label3.ForeColor=Color.DeepSkyBlue;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.DarkViolet;
			label10.Text="Medusa";
			label10.BackColor=Color.Black;
			label11.ForeColor=Color.Green;
			label11.Text="Psychic";
			label11.BackColor=Color.Black;

	      }
	      if (comboBox1.Text=="Veteran") 
	      {
	      	label1.Text="Veteran";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Vigilante";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Mafioso";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.DarkRed;
			label10.Text="Ambusher";
			label10.BackColor=Color.Black;
			label11.ForeColor=Color.OrangeRed;
			label11.Text="Pirate";
			label11.BackColor=Color.Black;

	      }
	      if (comboBox1.Text=="Vigilante") 
	      {
	      	label1.Text="Veteran";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Vigilante";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Mafioso";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.DarkRed;
			label10.Text="Ambusher";
			label10.BackColor=Color.Black;
			label11.ForeColor=Color.OrangeRed;
			label11.Text="Pirate";
			label11.BackColor=Color.Black;

	      }
	      if (comboBox1.Text=="Bodyguard") 
	      {
	      	label1.Text="Bodyguard";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Arsonist";
	      	label2.ForeColor=Color.Orange;
	      	label3.Text="Godfather";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.Green;
			label11.Text="Crusader";
			label11.BackColor=Color.Black;

	      }
	      if (comboBox1.Text=="Doctor") 
	      {
	      	label1.Text="Doctor";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Serial Killer";
	      	label2.ForeColor=Color.DarkBlue;
	      	label3.Text="Disguiser";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.DarkViolet;
			label11.Text="Potion Master";
			label11.BackColor=Color.Black;

	      }
	      if (comboBox1.Text=="Escort") 
	      {
	      	label1.Text="Escort";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Transporter";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Consort";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.DarkRed;
			label11.Text="Hypnotist";
			label11.BackColor=Color.Black;

	      }
	      if (comboBox1.Text=="Mayor") 
	      {
	      	label1.Text="Investigator";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Mayor";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Consigliere";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.YellowGreen;
			label10.Text="Plaguebearer";
			label10.BackColor=Color.Black;
			label11.ForeColor=Color.Green;
			label11.Text="Tracker";
			label11.BackColor=Color.Black;

	      }
	      if (comboBox1.Text=="Medium") 
	      {
	      	label1.Text="Medium";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Retributionist";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Janitor";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.DarkViolet;
			label10.Text="Necromancer";
			label10.BackColor=Color.Black;
			label11.ForeColor=Color.Green;
			label11.Text="Trapper";
			label11.BackColor=Color.Black;

		
	      }
	      if (comboBox1.Text=="Retributionist") 
	      {
	      	label1.Text="Medium";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Retributionist";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Janitor";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.DarkViolet;
			label10.Text="Necromancer";
			label10.BackColor=Color.Black;
			label11.ForeColor=Color.Green;
			label11.Text="Trapper";
			label11.BackColor=Color.Black;
	
	      }
	      if (comboBox1.Text=="Transporter")
	      {
	      	label1.Text="Transporter";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Escort";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Consort";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.DarkRed;
			label11.Text="Hypnotist";
			label11.BackColor=Color.Black;
	 
	      }
	      if (comboBox2.Text=="Disguiser")
	      {
	      	label1.Text="Doctor";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Serial Killer";
	      	label2.ForeColor=Color.DarkBlue;
	      	label3.Text="Disguiser";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.DarkViolet;
			label11.Text="Potion Master";
			label11.BackColor=Color.Black;
	
	      }
	      if (comboBox2.Text=="Forger")
	      {
	      	label1.Text="Lookout";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Witch";
	      	label2.ForeColor=Color.Purple;
	      	label3.Text="Forger";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.DarkViolet;
			label11.Text="Coven Leader";
			label11.BackColor=Color.Black;
	
	      }
	      if (comboBox2.Text=="Framer")
	      {
	      	label1.Text="Jester";
	      	label1.ForeColor=Color.HotPink;
	      	label2.Text="Vampire";
	      	label2.ForeColor=Color.Gray;
	      	label3.Text="Framer";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.DarkViolet;
			label11.Text="Hex Master";
			label11.BackColor=Color.Black;

		
	      }
	      if (comboBox2.Text=="Janitor")
	      {
	      	label1.Text="Medium";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Retributionist";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Janitor";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.DarkViolet;
			label10.Text="Necromancer";
			label10.BackColor=Color.Black;
			label11.ForeColor=Color.Green;
			label11.Text="Trapper";
			label11.BackColor=Color.Black;
	 
	      }
	      if (comboBox2.Text=="Godfather")
	      {
	      	label1.Text="Bodyguard";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Arsonist";
	      	label2.ForeColor=Color.Orange;
	      	label3.Text="Godfather";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.Green;
			label11.Text="Crusader";
			label11.BackColor=Color.Black;

		
	      }
	      if (comboBox2.Text=="Mafioso")
	      {
	      	label1.Text="Veteran";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Vigilante";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Mafioso";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.DarkRed;
			label10.Text="Ambusher";
			label10.BackColor=Color.Black;
			label11.ForeColor=Color.OrangeRed;
			label11.Text="Pirate";
			label11.BackColor=Color.Black;
   	
		
	      }
	      if (comboBox2.Text=="Blackmailer")
	      {
	      	label1.Text="Spy";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Jailor";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Blackmailer";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.White;
			label11.Text="Guardian Angel";
			label11.BackColor=Color.Black;
	
	      }
	      if (comboBox2.Text=="Consigliere")
	      {
	      	label1.Text="Investigator";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Mayor";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Consigliere";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.YellowGreen;
			label10.Text="Plaguebearer";
			label10.BackColor=Color.Black;
			label11.ForeColor=Color.Green;
			label11.Text="Tracker";
			label11.BackColor=Color.Black;

	      }
	      if (comboBox2.Text=="Consort")
	      {
	      	label1.Text="Transporter";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Escort";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Consort";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.DarkRed;
			label11.Text="Hypnotist";
			label11.BackColor=Color.Black;

	      }
	      if (comboBox3.Text=="Amnesiac")
	      {
	      	label1.Text="Vampire Hunter";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Survivor";
	      	label2.ForeColor=Color.Gold;
	      	label3.Text="Amnesiac";
	      	label3.ForeColor=Color.DeepSkyBlue;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.Green;
			label10.Text="Psychic";
			label10.BackColor=Color.Black;
			label11.ForeColor=Color.DarkViolet;
			label11.Text="Medusa";
			label11.BackColor=Color.Black;

	      }
	      if (comboBox3.Text=="Survivor")
	      {
	      	label1.Text="Vampire Hunter";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Survivor";
	      	label2.ForeColor=Color.Gold;
	      	label3.Text="Amnesiac";
	      	label3.ForeColor=Color.DeepSkyBlue;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.Green;
			label10.Text="Psychic";
			label10.BackColor=Color.Black;
			label11.ForeColor=Color.DarkViolet;
			label11.Text="Medusa";
			label11.BackColor=Color.Black;

	      }
	      if (comboBox3.Text=="Vampire")
	      {
	      	label1.Text="Jester";
	      	label1.ForeColor=Color.HotPink;
	      	label2.Text="Vampire";
	      	label2.ForeColor=Color.Gray;
	      	label3.Text="Framer";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.DarkViolet;
			label11.Text="Hex Master";
			label11.BackColor=Color.Black;

		
	      }
	      if (comboBox3.Text=="Executioner")
	      {
	      	label1.Text="Sheriff";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Executioner";
	      	label2.ForeColor=Color.Gray;
	      	label3.Text="Werewolf";
	      	label3.ForeColor=Color.Brown;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.DarkViolet;
			label11.Text="Poisoner";
			label11.BackColor=Color.Black;

		
	      }
	      if (comboBox3.Text=="Jester")
	      {
	      	label1.Text="Jester";
	      	label1.ForeColor=Color.HotPink;
	      	label2.Text="Vampire";
	      	label2.ForeColor=Color.Gray;
	      	label3.Text="Framer";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.DarkViolet;
			label11.Text="Hex Master";
			label11.BackColor=Color.Black;

		
	      }
	      if (comboBox3.Text=="Witch")
	      {
	      	label1.Text="Lookout";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Witch";
	      	label2.ForeColor=Color.Purple;
	      	label3.Text="Forger";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.DarkViolet;
			label11.Text="Coven Leader";
			label11.BackColor=Color.Black;

	      
		
	      }
	      if (comboBox3.Text=="Arsonist")
	      {
	      	label1.Text="Bodyguard";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Arsonist";
	      	label2.ForeColor=Color.Orange;
	      	label3.Text="Godfather";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.Green;
			label11.Text="Crusader";
			label11.BackColor=Color.Black;

	      
		
	      }
	      if (comboBox3.Text=="Serial Killer")
	      {
	      	label1.Text="Doctor";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Serial Killer";
	      	label2.ForeColor=Color.DarkBlue;
	      	label3.Text="Disguiser";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.DarkViolet;
			label11.Text="Potion Master";
			label11.BackColor=Color.Black;

	      	
		
	      }
	      if (comboBox3.Text=="Werewolf")
	      {
	      	label1.Text="Sheriff";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Executioner";
	      	label2.ForeColor=Color.Gray;
	      	label3.Text="Werewolf";
	      	label3.ForeColor=Color.Brown;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.DarkViolet;
			label11.Text="Poisoner";
			label11.BackColor=Color.Black;

	      	
		
	      }
	      if (comboBox4.Text=="Crusader - Coven Town") 
	      {
	      	label11.ForeColor=Color.Green;
	      	label11.BackColor=Color.Black;
	      	label1.Text="Bodyguard";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Arsonist";
	      	label2.ForeColor=Color.Orange;
	      	label3.Text="Godfather";
	      	label11.Text="Crusader";	      	
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;

		
	      }
	      if (comboBox4.Text=="Trapper - Coven Town") 
	      {
	      	label10.ForeColor=Color.Green;
	      	label10.BackColor=Color.Black;
	      	label11.Visible=true;
	      	label11.ForeColor=Color.DarkViolet;
	      	label11.BackColor=Color.Black;
	      	label11.Text="Necromancer";
	      	label10.Text="Trapper";
	      	label1.Text="Medium";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Retributionist";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Janitor";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;

		
	      }
	      if (comboBox4.Text=="Tracker - Coven Town") 
	      {
	      	label10.ForeColor=Color.Green;
	      	label10.BackColor=Color.Black;
	      	label11.Visible=true;
	      	label11.ForeColor=Color.YellowGreen;
	      	label11.BackColor=Color.Black;
	      	label11.Text="PlagueBearer";
	      	label10.Text="Tracker";
	      	label1.Text="Mayor";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Investigator";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Consigliere";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;

		
	      }
	      if (comboBox4.Text=="Psychic - Coven Town") 
	      {
	        label10.Text="Psychic";
	      	label10.ForeColor=Color.Green;
	      	label10.BackColor=Color.Black;
	      	label11.Visible=true;
	      	label11.ForeColor=Color.DarkViolet;
	      	label11.BackColor=Color.Black;
	      	label11.Text="Medusa";
	      	label1.Text="Vampire Hunter";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Amnesiac";
	      	label2.ForeColor=Color.DeepSkyBlue;
	      	label3.Text="Survivor";
	      	label3.ForeColor=Color.Gold;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Hypnotist - Coven Mafia") 
	      {
	        label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
	      	label11.Visible=true;
	      	label11.ForeColor=Color.Green;
	      	label11.BackColor=Color.Black;
	      	label11.Text="Escort";
	      	label1.Text="Transporter";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Consort";
	      	label2.ForeColor=Color.DarkRed;
	      	label3.Text="Hypnotist";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Ambusher - Coven Mafia") 
	      {
	        label10.ForeColor=Color.OrangeRed;
			label10.Text="Pirate";
			label10.BackColor=Color.Black;
	      	label11.Visible=true;
	      	label11.ForeColor=Color.Green;
	      	label11.BackColor=Color.Black;
	      	label11.Text="Veteran";
	      	label1.Text="Vigilante";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Ambusher";
	      	label2.ForeColor=Color.DarkRed;
	      	label3.Text="Mafioso";
	      	label3.ForeColor=Color.DarkRed;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Guardian Angel - Coven Neutral") 
	      {
	        label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
	      	label11.Visible=true;
	      	label11.ForeColor=Color.DarkRed;
	      	label11.BackColor=Color.Black;
	      	label11.Text="Blackmailer";
	      	label1.Text="Guardian Angel";
	      	label1.ForeColor=Color.White;
	      	label2.Text="Jailor";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Spy";
	      	label3.ForeColor=Color.Green;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Juggernaut - Coven Neutral") 
	      {
	        label10.ForeColor=Color.White;
			label10.Text="";
			label10.BackColor=Color.Transparent;
			label11.ForeColor=Color.White;
			label11.Text="";
			label11.BackColor=Color.Transparent;
			label1.ForeColor=Color.White;
			label1.Text="No Results For Investigator.";
			label1.BackColor=Color.Transparent;
	      	label2.ForeColor=Color.White;
			label2.Text="";
			label2.BackColor=Color.Transparent;
            label3.ForeColor=Color.White;
			label3.Text="";
			label3.BackColor=Color.Transparent;			
	      }
	      if (comboBox4.Text=="Pirate - Coven Neutral") 
	      {
	        label10.ForeColor=Color.OrangeRed;
			label10.Text="Pirate";
			label10.BackColor=Color.Black;
	      	label11.Visible=true;
	      	label11.ForeColor=Color.DarkRed;
	      	label11.BackColor=Color.Black;
	      	label11.Text="Ambusher";
	      	label1.Text="Mafioso";
	      	label1.ForeColor=Color.DarkRed;
	      	label2.Text="Vigilante";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Veteran";
	      	label3.ForeColor=Color.Green;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Plaguebearer - Coven Neutral") 
	      {
	        label10.ForeColor=Color.YellowGreen;
			label10.Text="Plaguebearer";
			label10.BackColor=Color.Black;
	      	label11.Visible=true;
	      	label11.ForeColor=Color.DarkRed;
	      	label11.BackColor=Color.Black;
	      	label11.Text="Consigliere";
	      	label1.Text="Tracker";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Investigator";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Mayor";
	      	label3.ForeColor=Color.Green;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Pestilance - Coven Neutral") 
	      {
	        label10.ForeColor=Color.YellowGreen;
			label10.Text="Plaguebearer";
			label10.BackColor=Color.Black;
	      	label11.Visible=true;
	      	label11.ForeColor=Color.DarkRed;
	      	label11.BackColor=Color.Black;
	      	label11.Text="Consigliere";
	      	label1.Text="Tracker";
	      	label1.ForeColor=Color.Green;
	      	label2.Text="Investigator";
	      	label2.ForeColor=Color.Green;
	      	label3.Text="Mayor";
	      	label3.ForeColor=Color.Green;
	      	label1.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Coven Leader - Coven Evil") 
	      {
	        label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
	      	label11.ForeColor=Color.DarkViolet;
			label11.Text="Coven Leader";
			label11.BackColor=Color.Black;
	      	label1.Text="Lookout";
	      	label1.ForeColor=Color.Green;
	      	label3.Text="Forger";
	      	label3.ForeColor=Color.DarkRed;
	      	label2.Text="Witch";
	      	label2.ForeColor=Color.DarkViolet;
	      	label1.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Hex Master - Coven Evil") 
	      {
	        label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
	      	label11.ForeColor=Color.HotPink;
			label11.Text="Jester";
			label11.BackColor=Color.Black;
	      	label1.Text="Vampire";
	      	label1.ForeColor=Color.Gray;
	      	label3.Text="Framer";
	      	label3.ForeColor=Color.DarkRed;
	      	label2.Text="Hex Master";
	      	label2.ForeColor=Color.DarkViolet;
	      	label1.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Poisoner - Coven Evil") 
	      {
	        label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
	      	label11.ForeColor=Color.DarkViolet;
			label11.Text="Poisoner";
			label11.BackColor=Color.Black;
	      	label1.Text="Sheriff";
	      	label1.ForeColor=Color.Green;
	      	label3.Text="Werewolf";
	      	label3.ForeColor=Color.Brown;
	      	label2.Text="Executioner";
	      	label2.ForeColor=Color.Gray;
	      	label1.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Potion Master - Coven Evil") 
	      {
	        label10.ForeColor=Color.White;
			label10.Text="- - - - - -";
			label10.BackColor=Color.Transparent;
	      	label11.ForeColor=Color.DarkViolet;
			label11.Text="Potion Master";
			label11.BackColor=Color.Black;
	      	label1.Text="Doctor";
	      	label1.ForeColor=Color.Green;
	      	label3.Text="Disguiser";
	      	label3.ForeColor=Color.DarkRed;
	      	label2.Text="Serial Killer";
	      	label2.ForeColor=Color.DarkBlue;
	      	label1.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Medusa - Coven Evil") 
	      {
	        label10.ForeColor=Color.Green;
			label10.Text="Psychic";
			label10.BackColor=Color.Black;
	      	label11.ForeColor=Color.Green;
			label11.Text="Vampire Hunter";
			label11.BackColor=Color.Black;
	      	label1.Text="Amnesiac";
	      	label1.ForeColor=Color.DeepSkyBlue;
	      	label3.Text="Survivor";
	      	label3.ForeColor=Color.Gold;
	      	label2.Text="Medusa";
	      	label2.ForeColor=Color.DarkViolet;
	      	label1.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Necromancer - Coven Evil") 
	      {
	        label10.ForeColor=Color.Green;
			label10.Text="Medium";
			label10.BackColor=Color.Black;
	      	label11.ForeColor=Color.Green;
			label11.Text="Trapper";
			label11.BackColor=Color.Black;
	      	label1.Text="Retributionist";
	      	label1.ForeColor=Color.Green;
	      	label3.Text="Janitor";
	      	label3.ForeColor=Color.DarkRed;
	      	label2.Text="Necromancer";
	      	label2.ForeColor=Color.DarkViolet;
	      	label1.BackColor=Color.Black;
	      	label2.BackColor=Color.Black;
	      	label3.BackColor=Color.Black;		
	      }
	      
	      
	      
	      
	      
		}
		void Button1Click(object sender, EventArgs e)
		{
			comboBox1.Visible=true;
				comboBox2.Visible=false;
				comboBox3.Visible=false;
				comboBox4.Visible=false;
				comboBox4.SelectedIndex = -1;
				comboBox2.SelectedIndex = -1;
				comboBox3.SelectedIndex = -1;
				label6.Visible=true;
				label9.BackColor=Color.Transparent;
				label9.ForeColor=Color.White;
				label9.Text="- - - - - -";
				label1.BackColor=Color.Transparent;
				label2.BackColor=Color.Transparent;
				label3.BackColor=Color.Transparent;
				label4.BackColor=Color.Transparent;
				label8.BackColor=Color.Transparent;
				label10.ForeColor=Color.White;
			    label10.Text="- - - - - -";
			    label10.BackColor=Color.Transparent;
			    label11.ForeColor=Color.White;
			    label11.Text="- - - - - -";
			    label11.BackColor=Color.Transparent;
				label8.Text="- - - - - -";
				label8.ForeColor=Color.White;
				label1.Text="- - - - - -";
				label2.Text="- - - - - -";
				label3.Text="- - - - - -";
				label4.Text="- - - - - -";
				label1.ForeColor=Color.White;
				label2.ForeColor=Color.White;
				label3.ForeColor=Color.White;
				label4.ForeColor=Color.White;
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			    comboBox1.Visible=false;
				comboBox2.Visible=true;
				comboBox3.Visible=false;
				label6.Visible=true;
				comboBox4.Visible=false;
				label10.ForeColor=Color.White;
			    label10.Text="- - - - - -";
			    label10.BackColor=Color.Transparent;
			    label11.ForeColor=Color.White;
			    label11.Text="- - - - - -";
			    label11.BackColor=Color.Transparent;
				comboBox4.SelectedIndex = -1;
				comboBox1.SelectedIndex = -1;
				comboBox3.SelectedIndex = -1;
				label9.BackColor=Color.Transparent;
				label9.ForeColor=Color.White;
				label9.Text="- - - - - -";
				label1.BackColor=Color.Transparent;
                label8.BackColor=Color.Transparent;
				label2.BackColor=Color.Transparent;
				label3.BackColor=Color.Transparent;
				label4.BackColor=Color.Transparent;
				label8.Text="- - - - - -";
				label8.ForeColor=Color.White;
				label1.Text="- - - - - -";
				label2.Text="- - - - - -";
				label3.Text="- - - - - -";
				label4.Text="- - - - - -";
				label1.ForeColor=Color.White;
				label2.ForeColor=Color.White;
				label3.ForeColor=Color.White;
				label4.ForeColor=Color.White;
	
		}
		void Button3Click(object sender, EventArgs e)
		{
			comboBox1.Visible=false;
				comboBox2.Visible=false;
				comboBox3.Visible=true;
				comboBox2.SelectedIndex = -1;
				comboBox1.SelectedIndex = -1;
				comboBox4.Visible=false;
				comboBox4.SelectedIndex = -1;
				label6.Visible=true;
				label9.BackColor=Color.Transparent;
				label9.ForeColor=Color.White;
				label10.ForeColor=Color.White;
			    label10.Text="- - - - - -";
			    label10.BackColor=Color.Transparent;
			    label11.ForeColor=Color.White;
			    label11.Text="- - - - - -";
			    label11.BackColor=Color.Transparent;
				label9.Text="- - - - - -";
				label1.BackColor=Color.Transparent;
				label2.BackColor=Color.Transparent;
				label3.BackColor=Color.Transparent;
				label4.BackColor=Color.Transparent;
				label8.BackColor=Color.Transparent;
				label8.Text="- - - - - -";
				label8.ForeColor=Color.White;
				label1.Text="- - - - - -";
				label2.Text="- - - - - -";
				label3.Text="- - - - - -";
				label4.Text="- - - - - -";
				label1.ForeColor=Color.White;
				label2.ForeColor=Color.White;
				label3.ForeColor=Color.White;
				label4.ForeColor=Color.White;
	
		}
		void Button5Click(object sender, EventArgs e)
		{
			if (comboBox1.Text=="Investigator") 
	      {
				label4.Text="Town Investigative";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Lookout") 
	      {
	      	label4.Text="Town Investigative";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Spy") 
	      {
	      	label4.Text="Town Investigative";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Sheriff") 
	      {
	      	label4.Text="Town Investigative";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Jailor") 
	      {
	      	label4.Text="Town Killing";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Vampire Hunter") 
	      {
	      	label4.Text="Town Killing";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Veteran") 
	      {
	      	label4.Text="Town Killing";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Vigilante") 
	      {
	      	label4.Text="Town Killing";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Bodyguard") 
	      {
	      	label4.Text="Town Protective";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Doctor") 
	      {
	      	label4.Text="Town Protective";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Escort") 
	      {
	      	label4.Text="Town Support";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Mayor") 
	      {
	      	label4.Text="Town Support";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Medium") 
	      {
	      	label4.Text="Town Support";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Retributionist") 
	      {
	      	label4.Text="Town Support";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Transporter")
	      {
	      	label4.Text="Town Support";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Disguiser")
	      {
	      	label4.Text="Mafia Deception";
				label4.ForeColor=Color.DarkRed;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Forger")
	      {
	      	label4.Text="Mafia Deception";
				label4.ForeColor=Color.DarkRed;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Framer")
	      {
	      	label4.Text="Mafia Deception";
				label4.ForeColor=Color.DarkRed;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Janitor")
	      {
	      	label4.Text="Mafia Deception";
				label4.ForeColor=Color.DarkRed;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Godfather")
	      {
	      	label4.Text="Mafia Killing";
				label4.ForeColor=Color.DarkRed;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Mafioso")
	      {
	      	label4.Text="Mafia Killing";
				label4.ForeColor=Color.DarkRed;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Blackmailer")
	      {
	      	label4.Text="Mafia Support";
				label4.ForeColor=Color.DarkRed;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Consigliere")
	      {
	      	label4.Text="Mafia Support";
				label4.ForeColor=Color.DarkRed;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Consort")
	      {
	      	label4.Text="Mafia Support";
				label4.ForeColor=Color.DarkRed;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Amnesiac")
	      {
	      	label4.Text="Neutral Benign";
				label4.ForeColor=Color.AliceBlue;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Survivor")
	      {
	      	label4.Text="Neutral Benign";
				label4.ForeColor=Color.AliceBlue;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Vampire")
	      {
	      	label4.Text="Neutral Chaos";
				label4.ForeColor=Color.AliceBlue;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Executioner")
	      {
	      	label4.Text="Neutral Evil";
				label4.ForeColor=Color.AliceBlue;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Jester")
	      {
	      	label4.Text="Neutral Evil";
				label4.ForeColor=Color.AliceBlue;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Witch")
	      {
	      	label4.Text="Neutral Evil";
				label4.ForeColor=Color.AliceBlue;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Arsonist")
	      {
	      	label4.Text="Neutral Killing";
				label4.ForeColor=Color.AliceBlue;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Serial Killer")
	      {
	      	label4.Text="Neutral Killing";
				label4.ForeColor=Color.AliceBlue;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Werewolf")
	      {
	      	label4.Text="Neutral Killing";
				label4.ForeColor=Color.AliceBlue;
				label4.BackColor=Color.Black;
		
	      }
	      if (comboBox4.Text=="Crusader - Coven Town") 
	      {
	      	label4.Text="Town Protective";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Trapper - Coven Town") 
	      {
	      	label4.Text="Town Protective";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;
	      }
	      if (comboBox4.Text=="Tracker - Coven Town") 
	      {
	      	label4.Text="Town Investigative";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;
	      }
	      if (comboBox4.Text=="Psychic - Coven Town") 
	      {
	        label4.Text="Town Investigative";
				label4.ForeColor=Color.Green;
				label4.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Hypnotist - Coven Mafia") 
	      {
	        label4.Text="Mafia Deception";
				label4.ForeColor=Color.DarkRed;
				label4.BackColor=Color.Black;	
	      }
	      if (comboBox4.Text=="Ambusher - Coven Mafia") 
	      {
	        label4.Text="Mafia Killing";
				label4.ForeColor=Color.DarkRed;
				label4.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Guardian Angel - Coven Neutral") 
	      {
	        label4.Text="Neutral Benign";
				label4.ForeColor=Color.AliceBlue;
				label4.BackColor=Color.Black;	
	      }
	      if (comboBox4.Text=="Juggernaut - Coven Neutral") 
	      {
	        label4.Text="Neutral Killing";
				label4.ForeColor=Color.AliceBlue;
				label4.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Pirate - Coven Neutral") 
	      {
	        label4.Text="Neutral Chaos";
				label4.ForeColor=Color.AliceBlue;
				label4.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Plaguebearer - Coven Neutral") 
	      {
	        label4.Text="Neutral Chaos";
				label4.ForeColor=Color.AliceBlue;
				label4.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Pestilance - Coven Neutral") 
	      {
	        label4.Text="Neutral Chaos";
				label4.ForeColor=Color.AliceBlue;
				label4.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Coven Leader - Coven Evil") 
	      {
	         label4.Text="Coven Evil";
				label4.ForeColor=Color.DarkViolet;
				label4.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Hex Master - Coven Evil") 
	      {
	        label4.Text="Coven Evil";
				label4.ForeColor=Color.DarkViolet;
				label4.BackColor=Color.Black;	
	      }
	      if (comboBox4.Text=="Poisoner - Coven Evil") 
	      {
	        label4.Text="Coven Evil";
				label4.ForeColor=Color.DarkViolet;
				label4.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Potion Master - Coven Evil") 
	      {
	        label4.Text="Coven Evil";
				label4.ForeColor=Color.DarkViolet;
				label4.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Medusa - Coven Evil") 
	      {
	        label4.Text="Coven Evil";
				label4.ForeColor=Color.DarkViolet;
				label4.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Necromancer - Coven Evil") 
	      {
	        label4.Text="Coven Evil";
				label4.ForeColor=Color.DarkViolet;
				label4.BackColor=Color.Black;		
	      }
	
		}
		void Button6Click(object sender, EventArgs e)
		{
			comboBox1.Visible=false;
			comboBox2.SelectedIndex = -1;
				comboBox3.SelectedIndex = -1;
				comboBox1.SelectedIndex=-1;
				comboBox2.Visible=false;
				comboBox3.Visible=false;
				label10.ForeColor=Color.White;
			    label10.Text="- - - - - -";
			    label10.BackColor=Color.Transparent;
			    label11.ForeColor=Color.White;
			    label11.Text="- - - - - -";
			    label11.BackColor=Color.Transparent;
				label1.BackColor=Color.Transparent;
				label2.BackColor=Color.Transparent;
				label3.BackColor=Color.Transparent;
				label4.BackColor=Color.Transparent;
				label8.BackColor=Color.Transparent;
				label9.BackColor=Color.Transparent;
				label9.ForeColor=Color.White;
				label9.Text="- - - - - -";
				label1.Text="- - - - - -";
				label2.Text="- - - - - -";
				label3.Text="- - - - - -";
				label4.Text="- - - - - -";
				label8.Text="- - - - - -";
				label8.ForeColor=Color.White;
				label1.ForeColor=Color.White;
				label2.ForeColor=Color.White;
				label3.ForeColor=Color.White;
				label4.ForeColor=Color.White;
				label6.Visible=false;
	
		}
		void Button7Click(object sender, EventArgs e)
		{
			Application.Restart();
	
		}
		void Button8Click(object sender, EventArgs e)
		{
			Application.Exit();
	
		}
		void Button9Click(object sender, EventArgs e)
		{
			Form1 f1 = new Form1();
			f1.ShowDialog();
	
		}
		void Button10Click(object sender, EventArgs e)
		{
			if (comboBox1.Text=="Investigator") 
	      {
				label8.Text="Not Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Lookout") 
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Spy") 
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Sheriff") 
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Jailor") 
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Vampire Hunter") 
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Veteran") 
	      {
	      	label8.Text="Situationally Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Vigilante") 
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Bodyguard") 
	      {
	      	label8.Text="Situationally Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Doctor") 
	      {
	      	label8.Text="Situationally Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Escort") 
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Mayor") 
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Medium") 
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Retributionist") 
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Transporter")
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Disguiser")
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.DarkRed;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Forger")
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.DarkRed;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Framer")
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.DarkRed;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Janitor")
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.DarkRed;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Godfather")
	      {
	      	label8.Text="Certain Immune";
				label8.ForeColor=Color.DarkRed;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Mafioso")
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.DarkRed;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Blackmailer")
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.DarkRed;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Consigliere")
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.DarkRed;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Consort")
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.DarkRed;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Amnesiac")
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.AliceBlue;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Survivor")
	      {
	      	label8.Text="Situationally Immune";
				label8.ForeColor=Color.AliceBlue;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Vampire")
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.AliceBlue;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Executioner")
	      {
	      	label8.Text="Situationally Immune";
				label8.ForeColor=Color.AliceBlue;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Jester")
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.AliceBlue;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Witch")
	      {
	      	label8.Text="Situationally Immune";
				label8.ForeColor=Color.AliceBlue;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Arsonist")
	      {
	      	label8.Text="Certain Immune";
				label8.ForeColor=Color.AliceBlue;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Serial Killer")
	      {
	      	label8.Text="Certain Immune";
				label8.ForeColor=Color.AliceBlue;
				label8.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Werewolf")
	      {
	      	label8.Text="Situationally Immune";
				label8.ForeColor=Color.AliceBlue;
				label8.BackColor=Color.Black;
	      	
	      }
	      if (comboBox4.Text=="Crusader - Coven Town") 
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Trapper - Coven Town") 
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;
	      }
	      if (comboBox4.Text=="Tracker - Coven Town") 
	      {
	      	label8.Text="Not Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;
	      }
	      if (comboBox4.Text=="Psychic - Coven Town") 
	      {
	        label8.Text="Not Immune";
				label8.ForeColor=Color.Green;
				label8.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Hypnotist - Coven Mafia") 
	      {
	        label8.Text="Not Immune";
				label8.ForeColor=Color.DarkRed;
				label8.BackColor=Color.Black;	
	      }
	      if (comboBox4.Text=="Ambusher - Coven Mafia") 
	      {
	        label8.Text="Not Immune";
				label8.ForeColor=Color.DarkRed;
				label8.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Guardian Angel - Coven Neutral") 
	      {
	        label8.Text="Not Immune";
				label8.ForeColor=Color.AliceBlue;
				label8.BackColor=Color.Black;	
	      }
	      if (comboBox4.Text=="Juggernaut - Coven Neutral") 
	      {
	        label8.Text="Immune After Second Kill";
				label8.ForeColor=Color.AliceBlue;
				label8.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Pirate - Coven Neutral") 
	      {
	        label8.Text="Not Immune";
				label8.ForeColor=Color.AliceBlue;
				label8.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Plaguebearer - Coven Neutral") 
	      {
	        label8.Text="Certain Immune";
				label8.ForeColor=Color.AliceBlue;
				label8.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Pestilance - Coven Neutral") 
	      {
	        label8.Text="Certain Immune";
				label8.ForeColor=Color.AliceBlue;
				label8.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Coven Leader - Coven Evil") 
	      {
	         label8.Text="Situationally Immune";
				label8.ForeColor=Color.DarkViolet;
				label8.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Hex Master - Coven Evil") 
	      {
	        label8.Text="Not Immune";
				label8.ForeColor=Color.DarkViolet;
				label8.BackColor=Color.Black;	
	      }
	      if (comboBox4.Text=="Poisoner - Coven Evil") 
	      {
	        label8.Text="Not Immune";
				label8.ForeColor=Color.DarkViolet;
				label8.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Potion Master - Coven Evil") 
	      {
	        label8.Text="Not Immune";
				label8.ForeColor=Color.DarkViolet;
				label8.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Medusa - Coven Evil") 
	      {
	        label8.Text="Not Immune";
				label8.ForeColor=Color.DarkViolet;
				label8.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Necromancer - Coven Evil") 
	      {
	        label8.Text="Not Immune";
				label8.ForeColor=Color.DarkViolet;
				label8.BackColor=Color.Black;		
	      }
	
		}
		void Button11Click(object sender, EventArgs e)
		{
			if (comboBox1.Text=="Investigator") 
	      {
				label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Lookout") 
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Spy") 
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Sheriff") 
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Jailor") 
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Vampire Hunter") 
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Veteran") 
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Vigilante") 
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Bodyguard") 
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Doctor") 
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Escort") 
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Mayor") 
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Medium") 
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Retributionist") 
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox1.Text=="Transporter")
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Disguiser")
	      {
	      	label9.Text="Certain Suspicious";
				label9.ForeColor=Color.DarkRed;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Forger")
	      {
	      	label9.Text="Certain Suspicious";
				label9.ForeColor=Color.DarkRed;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Framer")
	      {
	      	label9.Text="Certain Suspicious";
				label9.ForeColor=Color.DarkRed;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Janitor")
	      {
	      	label9.Text="Certain Suspicious";
				label9.ForeColor=Color.DarkRed;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Godfather")
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.DarkRed;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Mafioso")
	      {
	      	label9.Text="Certain Suspicious";
				label9.ForeColor=Color.DarkRed;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Blackmailer")
	      {
	      	label9.Text="Certain Suspicious";
				label9.ForeColor=Color.DarkRed;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Consigliere")
	      {
	      	label9.Text="Certain Suspicious";
				label9.ForeColor=Color.DarkRed;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox2.Text=="Consort")
	      {
	      	label9.Text="Certain Suspicious";
				label9.ForeColor=Color.DarkRed;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Amnesiac")
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.AliceBlue;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Survivor")
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.AliceBlue;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Vampire")
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.AliceBlue;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Executioner")
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.AliceBlue;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Jester")
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.AliceBlue;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Witch")
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.AliceBlue;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Arsonist")
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.AliceBlue;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Serial Killer")
	      {
	      	label9.Text="Certain Suspicious";
				label9.ForeColor=Color.AliceBlue;
				label9.BackColor=Color.Black;
		
	      }
	      if (comboBox3.Text=="Werewolf")
	      {
	      	label9.Text="Situationally Suspicious";
				label9.ForeColor=Color.AliceBlue;
				label9.BackColor=Color.Black;
	      	
	      }
	      if (comboBox4.Text=="Crusader - Coven Town") 
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Trapper - Coven Town") 
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;
	      }
	      if (comboBox4.Text=="Tracker - Coven Town") 
	      {
	      	label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;
	      }
	      if (comboBox4.Text=="Psychic - Coven Town") 
	      {
	        label9.Text="Certain Innocent";
				label9.ForeColor=Color.Green;
				label9.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Hypnotist - Coven Mafia") 
	      {
	        label9.Text="Certain Suspicious";
				label9.ForeColor=Color.DarkRed;
				label9.BackColor=Color.Black;	
	      }
	      if (comboBox4.Text=="Ambusher - Coven Mafia") 
	      {
	        label9.Text="Certain Suspicious";
				label9.ForeColor=Color.DarkRed;
				label9.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Guardian Angel - Coven Neutral") 
	      {
	        label9.Text="Certain Innocent";
				label9.ForeColor=Color.AliceBlue;
				label9.BackColor=Color.Black;	
	      }
	      if (comboBox4.Text=="Juggernaut - Coven Neutral") 
	      {
	        label9.Text="Certain Innocent";
				label9.ForeColor=Color.AliceBlue;
				label9.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Pirate - Coven Neutral") 
	      {
	        label9.Text="Certain Innocent";
				label9.ForeColor=Color.AliceBlue;
				label9.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Plaguebearer - Coven Neutral") 
	      {
	        label9.Text="Certain Innocent";
				label9.ForeColor=Color.AliceBlue;
				label9.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Pestilance - Coven Neutral") 
	      {
	        label9.Text="Certain Innocent";
				label9.ForeColor=Color.AliceBlue;
				label9.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Coven Leader - Coven Evil") 
	      {
	         label9.Text="Situationally Suspicious";
				label9.ForeColor=Color.DarkViolet;
				label9.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Hex Master - Coven Evil") 
	      {
	        label9.Text="Situationally Suspicious";
				label9.ForeColor=Color.DarkViolet;
				label9.BackColor=Color.Black;	
	      }
	      if (comboBox4.Text=="Poisoner - Coven Evil") 
	      {
	        label9.Text="Situationally Suspicious";
				label9.ForeColor=Color.DarkViolet;
				label9.BackColor=Color.Black;	
	      }
	      if (comboBox4.Text=="Potion Master - Coven Evil") 
	      {
	        label9.Text="Situationally Suspicious";
				label9.ForeColor=Color.DarkViolet;
				label9.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Medusa - Coven Evil") 
	      {
	        label9.Text="Situationally Suspicious";
				label9.ForeColor=Color.DarkViolet;
				label9.BackColor=Color.Black;		
	      }
	      if (comboBox4.Text=="Necromancer - Coven Evil") 
	      {
	        label9.Text="Situationally Suspicious";
				label9.ForeColor=Color.DarkViolet;
				label9.BackColor=Color.Black;		
	      }
	
		}
		
		void Button13Click(object sender, EventArgs e)
		{
			Form4 f4 = new Form4();
			f4.Show();
	
		}
		void Button1MouseEnter(object sender, EventArgs e)
		{
			button1.Location= new Point(2,40);
			button1.Size=new Size(155,26);
			
	
		}
		void Button1MouseLeave(object sender, EventArgs e)
		{
			button1.Size=new Size(135,23);
			button1.Location=new Point(12,42);
	
		}
		void Button2MouseEnter(object sender, EventArgs e)
		{
			button2.Location=new Point(166,40);
			button2.Size=new Size(155,26);
	
		}
		void Button2MouseLeave(object sender, EventArgs e)
		{
			button2.Size=new Size(135,23);
			button2.Location=new Point(173,42);
	
		}
		void Button3MouseEnter(object sender, EventArgs e)
		{
			button3.Location=new Point(323,40);
			button3.Size=new Size(155,26);
	
		}
		void Button3MouseLeave(object sender, EventArgs e)
		{
			button3.Size=new Size(135,23);
			button3.Location=new Point(333,42);
	
		}
		void Button13MouseEnter(object sender, EventArgs e)
		{
			button13.BackColor = Color.OrangeRed;
			button13.FlatStyle=FlatStyle.Flat;
	
		}
		void Button13MouseLeave(object sender, EventArgs e)
		{
			button13.BackColor = SystemColors.Control;
			button13.FlatStyle=FlatStyle.Standard;
	
		}
		void Button4MouseEnter(object sender, EventArgs e)
		{
			button4.Font=new Font("Microsoft Sans Serif",9,FontStyle.Bold);
			button4.BackColor = Color.Yellow;
			button4.FlatStyle=FlatStyle.Flat;
	
		}
		void Button4MouseLeave(object sender, EventArgs e)
		{
			button4.Font=new Font("Microsoft Sans Serif",8,FontStyle.Regular);
			button4.BackColor = SystemColors.Control;
			button4.FlatStyle=FlatStyle.Standard;
	
		}
		void Button5MouseEnter(object sender, EventArgs e)
		{
			button5.Font=new Font("Microsoft Sans Serif",9,FontStyle.Bold);
			button5.BackColor = Color.Green;
			button5.FlatStyle=FlatStyle.Flat;
	
		}
		void Button5MouseLeave(object sender, EventArgs e)
		{
			button5.Font=new Font("Microsoft Sans Serif",8,FontStyle.Regular);
			button5.BackColor = SystemColors.Control;
			button5.FlatStyle=FlatStyle.Standard;
	
		}
		void Button10MouseEnter(object sender, EventArgs e)
		{
			button10.Font=new Font("Microsoft Sans Serif",9,FontStyle.Bold);
			button10.BackColor = Color.Red;
			button10.FlatStyle=FlatStyle.Flat;
	
		}
		void Button10MouseLeave(object sender, EventArgs e)
		{
			button10.Font=new Font("Microsoft Sans Serif",8,FontStyle.Regular);
			button10.BackColor = SystemColors.Control;
			button10.FlatStyle=FlatStyle.Standard;
	
		}
		void Button11MouseEnter(object sender, EventArgs e)
		{
			button11.Font=new Font("Microsoft Sans Serif",9,FontStyle.Bold);
			button11.BackColor = Color.DeepSkyBlue;
			button11.FlatStyle=FlatStyle.Flat;
	
		}
		void Button11MouseLeave(object sender, EventArgs e)
		{
			button11.Font=new Font("Microsoft Sans Serif",8,FontStyle.Regular);
			button11.BackColor = SystemColors.Control;
			button11.FlatStyle=FlatStyle.Standard;
	
		}
		void Button6MouseEnter(object sender, EventArgs e)
		{
			button6.Font=new Font("Microsoft Sans Serif",9,FontStyle.Regular);
	
		}
		void Button6MouseLeave(object sender, EventArgs e)
		{
			button6.Font=new Font("Microsoft Sans Serif",8,FontStyle.Regular);
	
		}
		void Button14Click(object sender, EventArgs e)
		{
			if (button14.Text=="Coven Activation") 
			{
			button6.Size = new Size(230,27);
			textBox1.Visible=true;
			button15.Visible=true;
			}
			
	
		}
		void Button15Click(object sender, EventArgs e)
		{
			
				if (textBox1.Text=="Activation Code") 
			{
				MessageBox.Show("Please Enter An Activation Code!");				
			}
			if (textBox1.Text!="Activation Code" && textBox1.Text!="Coven2019NB") 
			{
				MessageBox.Show("Incorrect Activation Code!");
			}
			if (textBox1.Text=="Coven2019NB") 
			{
				MessageBox.Show("Coven Mode Succesfully Activated!");
				button12.Visible=true;
				label1.Location=new Point(151,249);
				label2.Location=new Point(263,249);
				label3.Location=new Point(386,249);
				label10.Visible=true;
				label11.Visible=true;
				textBox1.Visible=false;
				button15.Visible=false;				
				button6.Size=new Size(460,27);
				this.BackgroundImage=Image.FromFile("Coven_bckgrnd.jpg");
				button14.Text="Coven Activated";
				button16.Visible=true;
				button13.Visible=false;
				
			}
			
			
	
		}
		void Button12MouseEnter(object sender, EventArgs e)
		{
			button12.Location=new Point(166,81);
			button12.Size=new Size(155,26);
	
		}
		void Button12MouseLeave(object sender, EventArgs e)
		{			
			button12.Size=new Size(135,23);
			button12.Location=new Point(173,83);	
		}
		void Button12Click(object sender, EventArgs e)
		{
			label6.Visible=true;
			comboBox4.Visible=true;
			comboBox1.Visible=false;
				comboBox2.Visible=false;
				comboBox3.Visible=false;
				label10.ForeColor=Color.White;
			    label10.Text="- - - - - -";
			    label10.BackColor=Color.Transparent;
			    label11.ForeColor=Color.White;
			    label11.Text="- - - - - -";
			    label11.BackColor=Color.Transparent;
				label6.Visible=true;
				comboBox1.SelectedIndex = -1;
				comboBox3.SelectedIndex = -1;
				comboBox2.SelectedIndex = -1;
				label9.BackColor=Color.Transparent;
				label9.ForeColor=Color.White;
				label9.Text="- - - - - -";
				label1.BackColor=Color.Transparent;
                label8.BackColor=Color.Transparent;
				label2.BackColor=Color.Transparent;
				label3.BackColor=Color.Transparent;
				label4.BackColor=Color.Transparent;
				label8.Text="- - - - - -";
				label8.ForeColor=Color.White;
				label1.Text="- - - - - -";
				label2.Text="- - - - - -";
				label3.Text="- - - - - -";
				label4.Text="- - - - - -";
				label1.ForeColor=Color.White;
				label2.ForeColor=Color.White;
				label3.ForeColor=Color.White;
				label4.ForeColor=Color.White;
	
		}
		void Button16MouseEnter(object sender, EventArgs e)
		{
			button16.BackColor = Color.OrangeRed;
			button16.FlatStyle=FlatStyle.Flat;
	
		}
		void Button16MouseLeave(object sender, EventArgs e)
		{
			button16.BackColor = SystemColors.Control;
			button16.FlatStyle=FlatStyle.Standard;
	
		}
		void Button16Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();			
	
		}

	
	
		}
	}

