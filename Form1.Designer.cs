
namespace BatExecutor
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.batbox = new System.Windows.Forms.TextBox();
            this.Execute = new System.Windows.Forms.Button();
            this.Openbat = new System.Windows.Forms.Button();
            this.Savebat = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // batbox
            // 
            this.batbox.Location = new System.Drawing.Point(13, 13);
            this.batbox.Multiline = true;
            this.batbox.Name = "batbox";
            this.batbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.batbox.Size = new System.Drawing.Size(491, 290);
            this.batbox.TabIndex = 5;
            this.batbox.TextChanged += new System.EventHandler(this.batbox_TextChanged);
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(13, 309);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(75, 23);
            this.Execute.TabIndex = 1;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Openbat
            // 
            this.Openbat.Location = new System.Drawing.Point(147, 309);
            this.Openbat.Name = "Openbat";
            this.Openbat.Size = new System.Drawing.Size(75, 23);
            this.Openbat.TabIndex = 2;
            this.Openbat.Text = "Openbat";
            this.Openbat.UseVisualStyleBackColor = true;
            this.Openbat.Click += new System.EventHandler(this.Openbat_Click);
            // 
            // Savebat
            // 
            this.Savebat.Location = new System.Drawing.Point(285, 309);
            this.Savebat.Name = "Savebat";
            this.Savebat.Size = new System.Drawing.Size(75, 23);
            this.Savebat.TabIndex = 3;
            this.Savebat.Text = "Savebat";
            this.Savebat.UseVisualStyleBackColor = true;
            this.Savebat.Click += new System.EventHandler(this.Savebat_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(429, 309);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 339);
            this.ControlBox = false;
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Savebat);
            this.Controls.Add(this.Openbat);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.batbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "BatExecutor v0.01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox batbox;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Openbat;
        private System.Windows.Forms.Button Savebat;
        private System.Windows.Forms.Button Exit;
    }
}

