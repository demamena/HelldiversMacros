namespace HelldiversMacro
{
    partial class FormMain
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
            this.panel_items = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.button_addItem = new System.Windows.Forms.Button();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_items
            // 
            this.panel_items.AutoScroll = true;
            this.panel_items.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.panel_items.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_items.Location = new System.Drawing.Point(0, 0);
            this.panel_items.Name = "panel_items";
            this.panel_items.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel_items.Size = new System.Drawing.Size(684, 493);
            this.panel_items.TabIndex = 0;
            // 
            // panel_main
            // 
            this.panel_main.AutoSize = true;
            this.panel_main.Controls.Add(this.panel_items);
            this.panel_main.Controls.Add(this.button_addItem);
            this.panel_main.Controls.Add(this.button_save);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(684, 561);
            this.panel_main.TabIndex = 1;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Green;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(0, 527);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(684, 34);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_addItem
            // 
            this.button_addItem.BackColor = System.Drawing.SystemColors.Control;
            this.button_addItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_addItem.FlatAppearance.BorderSize = 0;
            this.button_addItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_addItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_addItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addItem.Location = new System.Drawing.Point(0, 493);
            this.button_addItem.Name = "button_addItem";
            this.button_addItem.Size = new System.Drawing.Size(684, 34);
            this.button_addItem.TabIndex = 2;
            this.button_addItem.Text = "Add New";
            this.button_addItem.UseVisualStyleBackColor = false;
            this.button_addItem.Click += new System.EventHandler(this.button_addItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.panel_main);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Helldivers Macro";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_items;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_addItem;
    }
}

