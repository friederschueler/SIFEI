﻿
namespace SIF.Visualization.Excel {

    partial class CellErrorInfoContainer {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            //
            // elementHost1
            // 
            this.elementHost1.SuspendLayout();
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.AutoSize = true;
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Child = null;
            // 
            // CellErrorInfoContainer
            //
            this.Controls.Add(this.elementHost1);
            this.Name = "CellErrorInfoContainer";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
    }
}
