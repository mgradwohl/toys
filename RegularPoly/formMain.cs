using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Drawing2D;


namespace RegularPoly
{
	public class formMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.NumericUpDown numericSize;
		private System.Windows.Forms.Label labelradius;
		private System.Windows.Forms.Label labeldiameter;
		public System.Windows.Forms.NumericUpDown numericSides;
		private System.Windows.Forms.CheckBox checkBoxCircle;
		private System.Windows.Forms.CheckBox checkBoxPoints;
		private System.Windows.Forms.CheckBox checkBoxLabels;
		private System.Windows.Forms.CheckBox checkBoxAngle;
		private System.Windows.Forms.Label labelOuterRadius;
		private System.Windows.Forms.Label labelsize;
		private System.Windows.Forms.Label labelBeta;
		private System.Windows.Forms.Label labelAlpha;
		private System.Windows.Forms.CheckBox checkWood;
		private System.Windows.Forms.Label labelsmalldiameter;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.TrackBar trackBarAlpha;
		private System.Windows.Forms.Label labelFormAlpha;
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
			numericSides.Minimum = 3;
			numericSize.Value = 12.0M;
			numericSides.Maximum = 359;
			numericSides.Value = (int)4;
			numericSize.Minimum = 2.0M;
			SetStyle(ControlStyles.DoubleBuffer, true);
			SetStyle(ControlStyles.ResizeRedraw, false);
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.buttonClose = new System.Windows.Forms.Button();
			this.numericSides = new System.Windows.Forms.NumericUpDown();
			this.labelBeta = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelAlpha = new System.Windows.Forms.Label();
			this.labelOuterRadius = new System.Windows.Forms.Label();
			this.labelsize = new System.Windows.Forms.Label();
			this.checkBoxCircle = new System.Windows.Forms.CheckBox();
			this.checkBoxPoints = new System.Windows.Forms.CheckBox();
			this.checkBoxLabels = new System.Windows.Forms.CheckBox();
			this.checkBoxAngle = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.numericSize = new System.Windows.Forms.NumericUpDown();
			this.labelradius = new System.Windows.Forms.Label();
			this.labeldiameter = new System.Windows.Forms.Label();
			this.checkWood = new System.Windows.Forms.CheckBox();
			this.labelsmalldiameter = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.trackBarAlpha = new System.Windows.Forms.TrackBar();
			this.labelFormAlpha = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericSides)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonClose.Location = new System.Drawing.Point(384, 407);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.TabIndex = 15;
			this.buttonClose.Text = "Close";
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// numericSides
			// 
			this.numericSides.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.numericSides.Location = new System.Drawing.Point(64, 9);
			this.numericSides.Name = "numericSides";
			this.numericSides.Size = new System.Drawing.Size(64, 24);
			this.numericSides.TabIndex = 1;
			this.numericSides.ValueChanged += new System.EventHandler(this.numericSides_ValueChanged);
			this.numericSides.Leave += new System.EventHandler(this.numericSides_ValueChanged);
			// 
			// labelBeta
			// 
			this.labelBeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelBeta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelBeta.Location = new System.Drawing.Point(384, 60);
			this.labelBeta.Name = "labelBeta";
			this.labelBeta.Size = new System.Drawing.Size(72, 14);
			this.labelBeta.TabIndex = 4;
			this.labelBeta.Text = "labelBeta";
			this.labelBeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Sides:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelAlpha
			// 
			this.labelAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelAlpha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAlpha.Location = new System.Drawing.Point(384, 82);
			this.labelAlpha.Name = "labelAlpha";
			this.labelAlpha.Size = new System.Drawing.Size(72, 14);
			this.labelAlpha.TabIndex = 5;
			this.labelAlpha.Text = "labelAlpha";
			this.labelAlpha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelOuterRadius
			// 
			this.labelOuterRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelOuterRadius.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelOuterRadius.Location = new System.Drawing.Point(384, 38);
			this.labelOuterRadius.Name = "labelOuterRadius";
			this.labelOuterRadius.Size = new System.Drawing.Size(72, 14);
			this.labelOuterRadius.TabIndex = 7;
			this.labelOuterRadius.Text = "labelRadius";
			this.labelOuterRadius.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelsize
			// 
			this.labelsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelsize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelsize.Location = new System.Drawing.Point(384, 104);
			this.labelsize.Name = "labelsize";
			this.labelsize.Size = new System.Drawing.Size(72, 14);
			this.labelsize.TabIndex = 6;
			this.labelsize.Text = "labelsize";
			this.labelsize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// checkBoxCircle
			// 
			this.checkBoxCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxCircle.Checked = true;
			this.checkBoxCircle.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxCircle.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxCircle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBoxCircle.Location = new System.Drawing.Point(8, 416);
			this.checkBoxCircle.Name = "checkBoxCircle";
			this.checkBoxCircle.Size = new System.Drawing.Size(64, 15);
			this.checkBoxCircle.TabIndex = 10;
			this.checkBoxCircle.Text = "Circle";
			this.checkBoxCircle.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
			// 
			// checkBoxPoints
			// 
			this.checkBoxPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxPoints.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxPoints.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBoxPoints.Location = new System.Drawing.Point(84, 416);
			this.checkBoxPoints.Name = "checkBoxPoints";
			this.checkBoxPoints.Size = new System.Drawing.Size(64, 15);
			this.checkBoxPoints.TabIndex = 11;
			this.checkBoxPoints.Text = "Points";
			this.checkBoxPoints.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
			// 
			// checkBoxLabels
			// 
			this.checkBoxLabels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxLabels.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxLabels.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBoxLabels.Location = new System.Drawing.Point(160, 416);
			this.checkBoxLabels.Name = "checkBoxLabels";
			this.checkBoxLabels.Size = new System.Drawing.Size(64, 15);
			this.checkBoxLabels.TabIndex = 12;
			this.checkBoxLabels.Text = "Labels";
			this.checkBoxLabels.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
			// 
			// checkBoxAngle
			// 
			this.checkBoxAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxAngle.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxAngle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBoxAngle.Location = new System.Drawing.Point(236, 416);
			this.checkBoxAngle.Name = "checkBoxAngle";
			this.checkBoxAngle.Size = new System.Drawing.Size(64, 15);
			this.checkBoxAngle.TabIndex = 13;
			this.checkBoxAngle.Text = "Angle";
			this.checkBoxAngle.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(152, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "Size:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericSize
			// 
			this.numericSize.DecimalPlaces = 2;
			this.numericSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.numericSize.Increment = new System.Decimal(new int[] {
																		  25,
																		  0,
																		  0,
																		  131072});
			this.numericSize.Location = new System.Drawing.Point(208, 9);
			this.numericSize.Minimum = new System.Decimal(new int[] {
																		1,
																		0,
																		0,
																		0});
			this.numericSize.Name = "numericSize";
			this.numericSize.Size = new System.Drawing.Size(64, 24);
			this.numericSize.TabIndex = 3;
			this.numericSize.Value = new System.Decimal(new int[] {
																	  1,
																	  0,
																	  0,
																	  0});
			this.numericSize.ValueChanged += new System.EventHandler(this.numericSize_ValueChanged);
			this.numericSize.Leave += new System.EventHandler(this.numericSize_ValueChanged);
			// 
			// labelradius
			// 
			this.labelradius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelradius.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelradius.Location = new System.Drawing.Point(384, 148);
			this.labelradius.Name = "labelradius";
			this.labelradius.Size = new System.Drawing.Size(72, 14);
			this.labelradius.TabIndex = 8;
			this.labelradius.Text = "labelradius";
			this.labelradius.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labeldiameter
			// 
			this.labeldiameter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labeldiameter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labeldiameter.Location = new System.Drawing.Point(384, 16);
			this.labeldiameter.Name = "labeldiameter";
			this.labeldiameter.Size = new System.Drawing.Size(72, 14);
			this.labeldiameter.TabIndex = 9;
			this.labeldiameter.Text = "labeldiameter";
			this.labeldiameter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// checkWood
			// 
			this.checkWood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkWood.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkWood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkWood.Location = new System.Drawing.Point(312, 416);
			this.checkWood.Name = "checkWood";
			this.checkWood.Size = new System.Drawing.Size(64, 15);
			this.checkWood.TabIndex = 14;
			this.checkWood.Text = "Wood";
			this.checkWood.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
			// 
			// labelsmalldiameter
			// 
			this.labelsmalldiameter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelsmalldiameter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelsmalldiameter.Location = new System.Drawing.Point(384, 126);
			this.labelsmalldiameter.Name = "labelsmalldiameter";
			this.labelsmalldiameter.Size = new System.Drawing.Size(72, 14);
			this.labelsmalldiameter.TabIndex = 16;
			this.labelsmalldiameter.Text = "labelsmalldiameter";
			this.labelsmalldiameter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// checkBox1
			// 
			this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(8, 416);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(64, 15);
			this.checkBox1.TabIndex = 10;
			this.checkBox1.Text = "Circle";
			// 
			// checkBox2
			// 
			this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox2.Location = new System.Drawing.Point(88, 416);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(64, 15);
			this.checkBox2.TabIndex = 11;
			this.checkBox2.Text = "Points";
			// 
			// checkBox3
			// 
			this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox3.Location = new System.Drawing.Point(160, 416);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(64, 15);
			this.checkBox3.TabIndex = 12;
			this.checkBox3.Text = "Labels";
			// 
			// trackBarAlpha
			// 
			this.trackBarAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.trackBarAlpha.Location = new System.Drawing.Point(408, 224);
			this.trackBarAlpha.Maximum = 100;
			this.trackBarAlpha.Minimum = 25;
			this.trackBarAlpha.Name = "trackBarAlpha";
			this.trackBarAlpha.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBarAlpha.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.trackBarAlpha.Size = new System.Drawing.Size(45, 168);
			this.trackBarAlpha.TabIndex = 17;
			this.trackBarAlpha.TickFrequency = 5;
			this.trackBarAlpha.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarAlpha.Value = 100;
			this.trackBarAlpha.ValueChanged += new System.EventHandler(this.trackBarAlpha_ValueChanged);
			// 
			// labelFormAlpha
			// 
			this.labelFormAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelFormAlpha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelFormAlpha.Location = new System.Drawing.Point(421, 200);
			this.labelFormAlpha.Name = "labelFormAlpha";
			this.labelFormAlpha.Size = new System.Drawing.Size(32, 14);
			this.labelFormAlpha.TabIndex = 18;
			this.labelFormAlpha.Text = "100";
			this.labelFormAlpha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// formMain
			// 
			this.AcceptButton = this.buttonClose;
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.CancelButton = this.buttonClose;
			this.ClientSize = new System.Drawing.Size(464, 441);
			this.Controls.Add(this.labelFormAlpha);
			this.Controls.Add(this.trackBarAlpha);
			this.Controls.Add(this.labelsmalldiameter);
			this.Controls.Add(this.checkWood);
			this.Controls.Add(this.labeldiameter);
			this.Controls.Add(this.labelradius);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.numericSize);
			this.Controls.Add(this.checkBoxAngle);
			this.Controls.Add(this.checkBoxLabels);
			this.Controls.Add(this.checkBoxPoints);
			this.Controls.Add(this.checkBoxCircle);
			this.Controls.Add(this.labelsize);
			this.Controls.Add(this.labelOuterRadius);
			this.Controls.Add(this.labelAlpha);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelBeta);
			this.Controls.Add(this.numericSides);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox3);
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(472, 472);
			this.Name = "formMain";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Regular Polygon Example";
			this.Resize += new System.EventHandler(this.formMain_Resize);
			this.Load += new System.EventHandler(this.formMain_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.formMain_Paint);
			((System.ComponentModel.ISupportInitialize)(this.numericSides)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).EndInit();
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
	
		#region Paint Handler
		/// <summary>
		/// This is where all the cool stuff happens
		/// </summary>
		private void formMain_Paint(object sender, PaintEventArgs e)
		{
			// get and initialize graphics object
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.AntiAlias;
			
			// create pens, brushes, fonts for drawing
			Pen penNavy = new Pen(Color.Navy, 1.0F);
			Pen penRed = new Pen(Color.DarkRed, 1.0F);
			Pen penGreen = new Pen(Color.Green, 1.0F);
			Pen penBrown = new Pen(Color.Chocolate, 2.0F);
			Pen penBlack = new Pen(Color.Black, 1.0F);
			Font font = new Font("Verdana", 8.25F);
			SolidBrush brush = new SolidBrush(Color.Green);

			// prepare a rect to draw in, it's smaller than the client area to leave space for controls
			Rectangle rect = this.ClientRectangle;
			rect.Inflate(-label2.Height*4, -label2.Height*4);
			
			// Create a better brush to fill the poly
			LinearGradientBrush brushBrown = new LinearGradientBrush(this.ClientRectangle, Color.BurlyWood, Color.Brown, 45.0F, true);

			// Find the exact center the drawing rect, which is the exact center of circle
			PointF pointCenter = new Point(rect.X + (rect.Width / 2), rect.Y + (rect.Height / 2));

			// Find out how many sides the user has chosen
			int iSides = (int)numericSides.Value;

			// Create start and sweep angles and other values for drawing
			float beta = 360.0F/iSides;
			float theta = 270.0F;
			if (iSides % 2 == 0)
			{
				// if it is even, rotate it
				theta -= (beta / 2.0f);
			}
			float R = rect.Height/2.0F;
			float s = 2 * R * (float)(Math.Sin(Math.PI/iSides));

			// Calculate values for user
			float Diameter = (float)numericSize.Value;
			float Radius = Diameter / 2.0F;
			float Side = 2 * Radius * (float)(Math.Sin(Math.PI/iSides));
			float radius = (float) (Math.Cos((beta / 2.0F) * Math.PI/180) * Radius);
			float smalldiameter = radius * 2.0F;

			float diameter = 0.0F;
			if (iSides % 2 == 0)
			{
				diameter = Diameter;
			}
			else
			{
				diameter = Radius + radius;
			}

			// calculate scale
			float scale = R / radius;

			// update text labels on screen
			labelBeta.Text = String.Format("β {0:F}°", beta);
			labelAlpha.Text = String.Format("α {0:F}°", (180.0F - beta) / 2.0F);
			labelOuterRadius.Text = String.Format("R {0:F}", Radius);
			labelsize.Text = String.Format("s {0:F}", Side);
			labelradius.Text = String.Format("r {0:F}", radius);
			labeldiameter.Text = String.Format("D {0:F}", diameter);
			labelsmalldiameter.Text = String.Format("d {0:F}", smalldiameter);

			// fill an array with the Points that define the regular polygon
			// all points must fall on the circle and be equally spaced
			PointF[] path = new PointF[iSides];
			PointF[] interior = new PointF[iSides];
			PointF[] labels = new PointF[iSides];

			// find a point, adjacent to the radius, to position the label
			PointF pointBeta = new PointF(
				pointCenter.X + (30.0F * (float) Math.Cos((theta + (beta/2.0F)) * Math.PI/180)),
				pointCenter.Y + (30.0F * (float) Math.Sin((theta + (beta/2.0F)) * Math.PI/180)));

			for (int x = 0; x < iSides; x++)
			{
				path[x] = new PointF(
					pointCenter.X + (R * (float) Math.Cos(theta * Math.PI/180)),
					pointCenter.Y + (R * (float) Math.Sin(theta * Math.PI/180)));

				interior[x] = new PointF(
					pointCenter.X + ((R - (scale * 0.75F)) * (float) Math.Cos(theta * Math.PI/180)),
					pointCenter.Y + ((R - (scale * 0.75F)) * (float) Math.Sin(theta * Math.PI/180)));

				labels[x] = new PointF(
					pointCenter.X + ((R + 20.0F) * (float) Math.Cos(theta * Math.PI/180) - 5),
					pointCenter.Y + ((R + 20.0F) * (float) Math.Sin(theta * Math.PI/180)) - 5);

				theta += beta;
			}
			
			PointF[] poly = new PointF[5];
			for (int x = 0; x < (iSides-1); x++)
			{
				poly[0] = new PointF(interior[x].X, interior[x].Y);
				poly[1] = new PointF(path[x].X, path[x].Y);
				poly[2] = new PointF(path[x+1].X, path[x+1].Y);
				poly[3] = new PointF(interior[x+1].X, interior[x+1].Y);
				poly[4] = new PointF(interior[x].X, interior[x].Y);

				if (checkWood.Checked)
				{
					g.FillPolygon(brushBrown, poly);
				}
			}
			poly[0] = new PointF(interior[iSides-1].X, interior[iSides-1].Y);
			poly[1] = new PointF(path[iSides-1].X, path[iSides-1].Y);
			poly[2] = new PointF(path[0].X, path[0].Y);
			poly[3] = new PointF(interior[0].X, interior[0].Y);
			poly[4] = new PointF(interior[iSides-1].X, interior[iSides-1].Y);

			if (checkWood.Checked)
			{
				g.FillPolygon(brushBrown, poly);

				// draw the regular polygon
				g.DrawPolygon(penBlack, path);
				g.DrawPolygon(penBlack, interior);
	
				for (int x = 0; x < iSides; x++)
				{
					g.DrawLine(penBlack, path[x], interior[x]);
				}
			}
			
			if (checkBoxPoints.Checked)
			{
				for (int x = 0; x < iSides; x++)
				{
					// if the user wants points drawn, draw this one
					DrawPoint(g, penGreen, path[x]);
					// if the user wants them labeled, label them
					if (checkBoxLabels.Checked) g.DrawString((1+x).ToString(), font, brush, labels[x]);
				}
			}

			// draw center point
			if (checkBoxPoints.Checked) DrawPoint(g, penNavy, pointCenter);

			// calculate inner radius
			PointF pointradius = new PointF(
				path[0].X + ((path[1].X - path[0].X)/2),
				path[0].Y + ((path[1].Y - path[0].Y)/2));

			float fr =0.0F;
			if (iSides % 2 == 0)
			{
				fr =  pointCenter.Y - pointradius.Y;
			}
			else
			{
				fr = (float)Math.Sqrt( Math.Pow(pointradius.X-pointCenter.X, 2.0F) + Math.Pow(pointCenter.Y-pointradius.Y, 2.0F));
			}
			// figure out middle circle put a point on the radius at -45
			PointF pointX = new PointF(
				pointCenter.X + (fr * (float) Math.Cos(180 * Math.PI/180)),
				pointCenter.Y + (fr * (float) Math.Sin(180 * Math.PI/180)));

			PointF pointY = new PointF(
				pointCenter.X + (fr * (float) Math.Cos(270 * Math.PI/180)),
				pointCenter.Y + (fr * (float) Math.Sin(270 * Math.PI/180)));

			PointF pointTopLeft = new PointF(pointX.X, pointY.Y);

			if (checkBoxCircle.Checked)
			{
				g.DrawEllipse(penNavy, pointTopLeft.X, pointTopLeft.Y, fr * 2.0f, fr * 2.0f);
			}

			// Outer Radius
			PointF pointouterradius = new PointF(
				pointCenter.X + (R * (float) Math.Cos((theta + (beta/2.0F)) * Math.PI/180)),
				pointCenter.Y + (R * (float) Math.Sin((theta + (beta/2.0F)) * Math.PI/180)));
			
			if (iSides % 2 == 0)
			{
				fr =  pointCenter.Y - pointouterradius.Y;
			}
			else
			{
				fr = (float)Math.Sqrt( Math.Pow(pointouterradius.X-pointCenter.X, 2.0F) + Math.Pow(pointCenter.Y-pointouterradius.Y, 2.0F));
			}
			// figure out middle circle put a point on the radius at -45
			pointX = new PointF(
				pointCenter.X + (fr * (float) Math.Cos(180 * Math.PI/180)),
				pointCenter.Y + (fr * (float) Math.Sin(180 * Math.PI/180)));

			pointY = new PointF(
				pointCenter.X + (fr * (float) Math.Cos(270 * Math.PI/180)),
				pointCenter.Y + (fr * (float) Math.Sin(270 * Math.PI/180)));

			pointTopLeft = new PointF(pointX.X, pointY.Y);

			if (checkBoxCircle.Checked)
			{
				g.DrawEllipse(penNavy, pointTopLeft.X, pointTopLeft.Y, fr * 2.0f, fr * 2.0f);
			}

			// draw Angle
			if (checkBoxAngle.Checked)
			{
				g.DrawLine(penRed, path[0], pointCenter);
				g.DrawLine(penRed, pointCenter, path[1]);

				if (checkWood.Checked)
				{
					g.DrawLine(penRed, pointCenter, pointradius);
				}
				else
				{
					g.DrawLine(penRed, pointCenter, pointouterradius);
				}
			}

			// draw labels for angle, side, Radius
			SizeF size;
			if (checkBoxLabels.Checked && checkBoxAngle.Checked)
			{
				size = g.MeasureString("β", font);
				g.DrawString("β", font, brush, pointBeta.X - (size.Width/2), pointBeta.Y - (size.Height/2));
				
				size = g.MeasureString("R", font);
				g.DrawString("R", font, brush,
					pointCenter.X + ((path[0].X - pointCenter.X - size.Width)/2),
					pointCenter.Y + ((path[0].Y - pointCenter.Y)/2));

				if (checkWood.Checked)
				{
					size = g.MeasureString("α", font);
					g.DrawString("α", font, brush, path[0].X + size.Width, path[0].Y + (size.Height/4));
					//g.DrawLine(penNavy, labels[0], labels[1]);

					size = g.MeasureString("s", font);
					g.DrawString("s", font, brush,
						path[0].X + ((path[1].X - path[0].X - size.Width)/3),
						path[0].Y + ((path[1].Y - path[0].Y)/2) - 15);

					size = g.MeasureString("r", font);
					g.DrawString("r", font, brush,
						pointCenter.X + ((pointradius.X - pointCenter.X - size.Width)/2),
						pointCenter.Y + ((pointradius.Y - pointCenter.Y)/2));
				}
			}
		}
		#endregion // Paint Handler

		private void DrawPoint(Graphics graphics, Pen pen, PointF point)
		{
			RectangleF rect = new RectangleF(point.X - 2, point.Y - 2, 4, 4);
			graphics.DrawEllipse(pen, rect);
		}

		#region Resize Handler
		/// <summary>
		/// This ensures that the client area is always square
		/// </summary>
		private void formMain_Resize(object sender, System.EventArgs e)
		{
//			// when the user resizes the window, ensure the client area remains a perfect square
//			Rectangle rect = this.ClientRectangle;
//			Size s;
//			if (rect.Width > rect.Height)
//			{
//				s = new Size(rect.Height, rect.Height);
//			}
//			else
//			{
//				s = new Size(rect.Width, rect.Width);
//			}
//			this.ClientSize = s;
//			this.Invalidate(true);
		}
		#endregion //Resize Handler

		private void numericSides_ValueChanged(object sender, System.EventArgs e)
		{
	
			if (numericSides.Value < 3) numericSides.Value = 3;
			this.Invalidate(true);
		}

		private void formMain_Load(object sender, System.EventArgs e)
		{
			this.ClientSize = new Size(480, 480);
			labelAlpha.Visible = checkWood.Checked;
			labelradius.Visible = checkWood.Checked;
			labelsize.Visible = checkWood.Checked;
			labelsmalldiameter.Visible = checkWood.Checked;
//			numericSides.FlatStyle = FlatStyle.System;
//			numericSize.FlatStyle = FlatStyle.System;
		}

		private void checkBox_CheckedChanged(object sender, System.EventArgs e)
		{
			labelAlpha.Visible = checkWood.Checked;
			labelradius.Visible = checkWood.Checked;
			labelsize.Visible = checkWood.Checked;
			labelsmalldiameter.Visible = checkWood.Checked;
			this.Invalidate(true);
		}

		private void numericSize_ValueChanged(object sender, System.EventArgs e)
		{
			this.Invalidate(true);
		}

		private void trackBarAlpha_ValueChanged(object sender, System.EventArgs e)
		{
			labelFormAlpha.Text = String.Format("{0:G}", trackBarAlpha.Value);
			this.Opacity = trackBarAlpha.Value / 100.0F;
		}

		private void buttonClose_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
	}
}
