#region License Information
/* HeuristicLab
 * Copyright (C) 2002-2018 Heuristic and Evolutionary Algorithms Laboratory (HEAL)
 *
 * This file is part of HeuristicLab.
 *
 * HeuristicLab is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * HeuristicLab is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with HeuristicLab. If not, see <http://www.gnu.org/licenses/>.
 */
#endregion

namespace HeuristicLab.Core.Views {
  partial class OperatorsSidebar {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing) {
        if (components != null) components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.typeSelector = new HeuristicLab.Core.Views.TypeSelector();
      this.SuspendLayout();
      // 
      // typeSelector
      // 
      this.typeSelector.Caption = "Available Operators";
      this.typeSelector.Dock = System.Windows.Forms.DockStyle.Fill;
      this.typeSelector.Location = new System.Drawing.Point(0, 0);
      this.typeSelector.Name = "typeSelector";
      this.typeSelector.Size = new System.Drawing.Size(316, 296);
      this.typeSelector.TabIndex = 0;
      // 
      // OperatorsSidebar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
      this.Caption = "Operators";
      this.Controls.Add(this.typeSelector);
      this.Name = "OperatorsSidebar";
      this.Size = new System.Drawing.Size(316, 296);
      this.ResumeLayout(false);

    }

    #endregion

    protected TypeSelector typeSelector;
  }
}
