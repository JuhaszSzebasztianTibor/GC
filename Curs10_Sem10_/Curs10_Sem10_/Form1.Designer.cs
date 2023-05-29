namespace Curs10_Sem10_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonFinishUp = new System.Windows.Forms.Button();
            this.ButtonPartiton = new System.Windows.Forms.Button();
            this.ButtonSavePolygons = new System.Windows.Forms.Button();
            this.ButtonTriangulate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 438);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Allow Draw Mode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonFinishUp
            // 
            this.ButtonFinishUp.Location = new System.Drawing.Point(690, 74);
            this.ButtonFinishUp.Name = "ButtonFinishUp";
            this.ButtonFinishUp.Size = new System.Drawing.Size(98, 52);
            this.ButtonFinishUp.TabIndex = 1;
            this.ButtonFinishUp.Text = "Finish";
            this.ButtonFinishUp.UseVisualStyleBackColor = true;
            this.ButtonFinishUp.Click += new System.EventHandler(this.ButtonFinishUp_Click);
            // 
            // ButtonPartiton
            // 
            this.ButtonPartiton.Location = new System.Drawing.Point(690, 132);
            this.ButtonPartiton.Name = "ButtonPartiton";
            this.ButtonPartiton.Size = new System.Drawing.Size(98, 45);
            this.ButtonPartiton.TabIndex = 2;
            this.ButtonPartiton.Text = "Partition";
            this.ButtonPartiton.UseVisualStyleBackColor = true;
            this.ButtonPartiton.Click += new System.EventHandler(this.ButtonPartiton_Click);
            // 
            // ButtonSavePolygons
            // 
            this.ButtonSavePolygons.Location = new System.Drawing.Point(690, 183);
            this.ButtonSavePolygons.Name = "ButtonSavePolygons";
            this.ButtonSavePolygons.Size = new System.Drawing.Size(98, 49);
            this.ButtonSavePolygons.TabIndex = 3;
            this.ButtonSavePolygons.Text = "Save Polygon";
            this.ButtonSavePolygons.UseVisualStyleBackColor = true;
            this.ButtonSavePolygons.Click += new System.EventHandler(this.buttonSavePolygons_Click);
            // 
            // ButtonTriangulate
            // 
            this.ButtonTriangulate.Location = new System.Drawing.Point(690, 247);
            this.ButtonTriangulate.Name = "ButtonTriangulate";
            this.ButtonTriangulate.Size = new System.Drawing.Size(98, 46);
            this.ButtonTriangulate.TabIndex = 4;
            this.ButtonTriangulate.Text = "Triangulate";
            this.ButtonTriangulate.UseVisualStyleBackColor = true;
            this.ButtonTriangulate.Click += new System.EventHandler(this.buttonTriangulate_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(668, 308);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ButtonTriangulate);
            this.Controls.Add(this.ButtonSavePolygons);
            this.Controls.Add(this.ButtonPartiton);
            this.Controls.Add(this.ButtonFinishUp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonFinishUp;
        private System.Windows.Forms.Button ButtonPartiton;
        private System.Windows.Forms.Button ButtonSavePolygons;
        private System.Windows.Forms.Button ButtonTriangulate;
        private System.Windows.Forms.ListBox listBox1;
    }
}

