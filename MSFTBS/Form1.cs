using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;


namespace MSFTBS
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class formMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.LinkLabel linkAsset;
		private System.Windows.Forms.LinkLabel linkExercise;
		private System.Windows.Forms.LinkLabel linkVol;
		private System.Windows.Forms.LinkLabel linkMonthsToExpire;
		private System.Windows.Forms.LinkLabel linkRiskRate;
		private System.Windows.Forms.NumericUpDown numAssetPrice;
		private System.Windows.Forms.NumericUpDown numExercisePrice;
		private System.Windows.Forms.NumericUpDown numRiskRate;
		private System.Windows.Forms.NumericUpDown numVolatility;
		private System.Windows.Forms.NumericUpDown numMonthsToExpire;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label labelBS;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel linkLabel2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public formMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			UpdateBS();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(formMain));
			this.linkAsset = new System.Windows.Forms.LinkLabel();
			this.linkExercise = new System.Windows.Forms.LinkLabel();
			this.linkRiskRate = new System.Windows.Forms.LinkLabel();
			this.linkVol = new System.Windows.Forms.LinkLabel();
			this.linkMonthsToExpire = new System.Windows.Forms.LinkLabel();
			this.numAssetPrice = new System.Windows.Forms.NumericUpDown();
			this.numExercisePrice = new System.Windows.Forms.NumericUpDown();
			this.numRiskRate = new System.Windows.Forms.NumericUpDown();
			this.numVolatility = new System.Windows.Forms.NumericUpDown();
			this.numMonthsToExpire = new System.Windows.Forms.NumericUpDown();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.labelBS = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.numAssetPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numExercisePrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRiskRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numVolatility)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMonthsToExpire)).BeginInit();
			this.SuspendLayout();
			// 
			// linkAsset
			// 
			this.linkAsset.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkAsset.Location = new System.Drawing.Point(16, 16);
			this.linkAsset.Name = "linkAsset";
			this.linkAsset.Size = new System.Drawing.Size(144, 23);
			this.linkAsset.TabIndex = 0;
			this.linkAsset.TabStop = true;
			this.linkAsset.Text = "Stock Price";
			this.linkAsset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkAsset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAsset_LinkClicked);
			// 
			// linkExercise
			// 
			this.linkExercise.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkExercise.Location = new System.Drawing.Point(16, 60);
			this.linkExercise.Name = "linkExercise";
			this.linkExercise.Size = new System.Drawing.Size(144, 23);
			this.linkExercise.TabIndex = 1;
			this.linkExercise.TabStop = true;
			this.linkExercise.Text = "Strike Price";
			this.linkExercise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkExercise.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkExercise_LinkClicked);
			// 
			// linkRiskRate
			// 
			this.linkRiskRate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkRiskRate.Location = new System.Drawing.Point(16, 104);
			this.linkRiskRate.Name = "linkRiskRate";
			this.linkRiskRate.Size = new System.Drawing.Size(144, 23);
			this.linkRiskRate.TabIndex = 2;
			this.linkRiskRate.TabStop = true;
			this.linkRiskRate.Text = "Risk Free Interest Rate";
			this.linkRiskRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkRiskRate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRiskRate_LinkClicked);
			// 
			// linkVol
			// 
			this.linkVol.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkVol.Location = new System.Drawing.Point(16, 148);
			this.linkVol.Name = "linkVol";
			this.linkVol.Size = new System.Drawing.Size(144, 23);
			this.linkVol.TabIndex = 3;
			this.linkVol.TabStop = true;
			this.linkVol.Text = "Annual Volatility";
			this.linkVol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkVol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVol_LinkClicked);
			// 
			// linkMonthsToExpire
			// 
			this.linkMonthsToExpire.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkMonthsToExpire.Location = new System.Drawing.Point(16, 192);
			this.linkMonthsToExpire.Name = "linkMonthsToExpire";
			this.linkMonthsToExpire.Size = new System.Drawing.Size(144, 23);
			this.linkMonthsToExpire.TabIndex = 4;
			this.linkMonthsToExpire.TabStop = true;
			this.linkMonthsToExpire.Text = "Months Until Expired";
			this.linkMonthsToExpire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkMonthsToExpire.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMonthsToExpire_LinkClicked);
			// 
			// numAssetPrice
			// 
			this.numAssetPrice.DecimalPlaces = 4;
			this.numAssetPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.numAssetPrice.Location = new System.Drawing.Point(192, 17);
			this.numAssetPrice.Name = "numAssetPrice";
			this.numAssetPrice.Size = new System.Drawing.Size(104, 22);
			this.numAssetPrice.TabIndex = 5;
			this.numAssetPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numAssetPrice.Value = new System.Decimal(new int[] {
																		270000,
																		0,
																		0,
																		262144});
			this.numAssetPrice.Enter += new System.EventHandler(this.ValuesChanged);
			this.numAssetPrice.ValueChanged += new System.EventHandler(this.ValuesChanged);
			this.numAssetPrice.Leave += new System.EventHandler(this.ValuesChanged);
			// 
			// numExercisePrice
			// 
			this.numExercisePrice.DecimalPlaces = 4;
			this.numExercisePrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.numExercisePrice.Location = new System.Drawing.Point(192, 61);
			this.numExercisePrice.Name = "numExercisePrice";
			this.numExercisePrice.Size = new System.Drawing.Size(104, 22);
			this.numExercisePrice.TabIndex = 6;
			this.numExercisePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numExercisePrice.Value = new System.Decimal(new int[] {
																		   330000,
																		   0,
																		   0,
																		   262144});
			this.numExercisePrice.Enter += new System.EventHandler(this.ValuesChanged);
			this.numExercisePrice.ValueChanged += new System.EventHandler(this.ValuesChanged);
			this.numExercisePrice.Leave += new System.EventHandler(this.ValuesChanged);
			// 
			// numRiskRate
			// 
			this.numRiskRate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.numRiskRate.Location = new System.Drawing.Point(192, 105);
			this.numRiskRate.Name = "numRiskRate";
			this.numRiskRate.Size = new System.Drawing.Size(104, 22);
			this.numRiskRate.TabIndex = 7;
			this.numRiskRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numRiskRate.Value = new System.Decimal(new int[] {
																	  6,
																	  0,
																	  0,
																	  0});
			this.numRiskRate.Enter += new System.EventHandler(this.ValuesChanged);
			this.numRiskRate.ValueChanged += new System.EventHandler(this.ValuesChanged);
			this.numRiskRate.Leave += new System.EventHandler(this.ValuesChanged);
			// 
			// numVolatility
			// 
			this.numVolatility.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.numVolatility.Location = new System.Drawing.Point(192, 149);
			this.numVolatility.Name = "numVolatility";
			this.numVolatility.Size = new System.Drawing.Size(104, 22);
			this.numVolatility.TabIndex = 8;
			this.numVolatility.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numVolatility.Value = new System.Decimal(new int[] {
																		40,
																		0,
																		0,
																		0});
			this.numVolatility.Enter += new System.EventHandler(this.ValuesChanged);
			this.numVolatility.ValueChanged += new System.EventHandler(this.ValuesChanged);
			this.numVolatility.Leave += new System.EventHandler(this.ValuesChanged);
			// 
			// numMonthsToExpire
			// 
			this.numMonthsToExpire.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.numMonthsToExpire.Location = new System.Drawing.Point(192, 193);
			this.numMonthsToExpire.Name = "numMonthsToExpire";
			this.numMonthsToExpire.Size = new System.Drawing.Size(104, 22);
			this.numMonthsToExpire.TabIndex = 9;
			this.numMonthsToExpire.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numMonthsToExpire.Value = new System.Decimal(new int[] {
																			48,
																			0,
																			0,
																			0});
			this.numMonthsToExpire.Enter += new System.EventHandler(this.ValuesChanged);
			this.numMonthsToExpire.ValueChanged += new System.EventHandler(this.ValuesChanged);
			this.numMonthsToExpire.Leave += new System.EventHandler(this.ValuesChanged);
			// 
			// linkLabel1
			// 
			this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel1.Location = new System.Drawing.Point(16, 236);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(144, 23);
			this.linkLabel1.TabIndex = 10;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Black Scholes Call Value";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// labelBS
			// 
			this.labelBS.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBS.Location = new System.Drawing.Point(192, 237);
			this.labelBS.Name = "labelBS";
			this.labelBS.Size = new System.Drawing.Size(104, 22);
			this.labelBS.TabIndex = 11;
			this.labelBS.Text = "$0.00";
			this.labelBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(192, 232);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 22);
			this.label1.TabIndex = 11;
			this.label1.Text = "$0.00";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 272);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(280, 64);
			this.label2.TabIndex = 12;
			this.label2.Text = "This data is not implied or guaranteed to be accurate. I’m not a finance guy. I d" +
				"id check this against other sources. MSN Search for “Black-Scholes Microsoft” li" +
				"ke I did.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// linkLabel2
			// 
			this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel2.Location = new System.Drawing.Point(16, 344);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(280, 23);
			this.linkLabel2.TabIndex = 13;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Matt Gradwohl (mattgr@xbox.com)";
			this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// formMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(314, 376);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelBS);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.numMonthsToExpire);
			this.Controls.Add(this.numVolatility);
			this.Controls.Add(this.numRiskRate);
			this.Controls.Add(this.numExercisePrice);
			this.Controls.Add(this.numAssetPrice);
			this.Controls.Add(this.linkMonthsToExpire);
			this.Controls.Add(this.linkVol);
			this.Controls.Add(this.linkRiskRate);
			this.Controls.Add(this.linkExercise);
			this.Controls.Add(this.linkAsset);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(320, 408);
			this.MinimumSize = new System.Drawing.Size(320, 408);
			this.Name = "formMain";
			this.Opacity = 0.9;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "MSFT BS";
			((System.ComponentModel.ISupportInitialize)(this.numAssetPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numExercisePrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRiskRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numVolatility)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMonthsToExpire)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
			Application.Run(new formMain());
		}

		private void linkAsset_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("The current MSFT stock price", "MSFT BS Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void linkExercise_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Your 'strike' price", "MSFT BS Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void linkRiskRate_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("The current risk free interest rate", "MSFT BS Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void linkVol_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Sometimes called the 'standard deviation' or 'implied annual volatility'", "MSFT BS Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Black Scholes call value. MSN Search for Black-Scholes\r\n\r\nSee http://us.badm.washington.edu/frost/FIN560A/assignment%203%20answers.xls", "MSFT BS Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void linkMonthsToExpire_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Months until these options expire", "MSFT BS Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ValuesChanged(object sender, System.EventArgs e)
		{
			UpdateBS();
		}

		void UpdateBS()
		{
			double S, E, R, Sigma, T, BS, d1, d2;

			R = (double) numRiskRate.Value;
			R *= 0.01;

			Sigma = (double) numVolatility.Value;
			Sigma *= 0.01;

			T = (double) numMonthsToExpire.Value;
			T /= 12.0;

			E = (double) numExercisePrice.Value;
			
			S = (double) numAssetPrice.Value;

			d1 = (Math.Log(S/E) + (R + 0.5 * Math.Pow(Sigma,2))*T)/(Sigma * Math.Sqrt(T));
			d2 = d1 - Sigma * Math.Sqrt(T);

			//Compute and display the value of the call option
			BS = S * BSNormal(d1) - E * BSNormal(d2) * Math.Exp(-R * T);
	
			labelBS.Text = String.Format("{0:$#,##0.0000;($#,##0.0000);Zero}", BS);
		}
		
		double BSNormal(double x)
		{
			double ans, y;

			y = 1.0/(1.0 + 0.33267 * Math.Abs(x));
			ans = 1.0 - 0.3989422 * Math.Exp(-0.5 * Math.Pow(Math.Abs(x),2))*
				(0.4361836 * y - 0.1201676 * Math.Pow(y,2) + 0.9372980 * Math.Pow(y,3));
			if(x < 0.0)
				ans = 1 - ans;

			return ans;
		}

		private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("mailto:mattgr@xbox.com?Subject=Tell%20me%20about%20MSFTBS");
		}
	}
}
