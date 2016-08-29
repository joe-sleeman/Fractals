namespace Fractals
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
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnTree = new System.Windows.Forms.Button();
            this.btnSnowflake = new System.Windows.Forms.Button();
            this.btnDragon = new System.Windows.Forms.Button();
            this.btnCircles = new System.Windows.Forms.Button();
            this.nudDepth = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(16, 44);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(75, 23);
            this.btnTriangle.TabIndex = 0;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnTree
            // 
            this.btnTree.Location = new System.Drawing.Point(16, 73);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(75, 23);
            this.btnTree.TabIndex = 1;
            this.btnTree.Text = "Tree";
            this.btnTree.UseVisualStyleBackColor = true;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // btnSnowflake
            // 
            this.btnSnowflake.Location = new System.Drawing.Point(16, 102);
            this.btnSnowflake.Name = "btnSnowflake";
            this.btnSnowflake.Size = new System.Drawing.Size(75, 23);
            this.btnSnowflake.TabIndex = 2;
            this.btnSnowflake.Text = "Snowflake";
            this.btnSnowflake.UseVisualStyleBackColor = true;
            this.btnSnowflake.Click += new System.EventHandler(this.btnSnowflake_Click);
            // 
            // btnDragon
            // 
            this.btnDragon.Location = new System.Drawing.Point(16, 131);
            this.btnDragon.Name = "btnDragon";
            this.btnDragon.Size = new System.Drawing.Size(75, 23);
            this.btnDragon.TabIndex = 3;
            this.btnDragon.Text = "Dragon";
            this.btnDragon.UseVisualStyleBackColor = true;
            this.btnDragon.Click += new System.EventHandler(this.btnDragon_Click);
            // 
            // btnCircles
            // 
            this.btnCircles.Location = new System.Drawing.Point(16, 160);
            this.btnCircles.Name = "btnCircles";
            this.btnCircles.Size = new System.Drawing.Size(75, 23);
            this.btnCircles.TabIndex = 4;
            this.btnCircles.Text = "Circle";
            this.btnCircles.UseVisualStyleBackColor = true;
            this.btnCircles.Click += new System.EventHandler(this.btnCircles_Click);
            // 
            // nudDepth
            // 
            this.nudDepth.Location = new System.Drawing.Point(16, 19);
            this.nudDepth.Name = "nudDepth";
            this.nudDepth.Size = new System.Drawing.Size(75, 20);
            this.nudDepth.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudDepth);
            this.groupBox1.Controls.Add(this.btnCircles);
            this.groupBox1.Controls.Add(this.btnTree);
            this.groupBox1.Controls.Add(this.btnDragon);
            this.groupBox1.Controls.Add(this.btnTriangle);
            this.groupBox1.Controls.Add(this.btnSnowflake);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 197);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 862);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Fractals";
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.Button btnSnowflake;
        private System.Windows.Forms.Button btnDragon;
        private System.Windows.Forms.Button btnCircles;
        private System.Windows.Forms.NumericUpDown nudDepth;
        private System.Windows.Forms.GroupBox groupBox1;


    }
}

