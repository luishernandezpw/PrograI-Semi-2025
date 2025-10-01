
namespace miPrimerProyectoCsharp
{
    partial class frmNotas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idNotaLabel;
            System.Windows.Forms.Label idAlumnoLabel;
            System.Windows.Forms.Label idPeriodoLabel;
            System.Windows.Forms.Label fechaLabel;
            this.db_academicaDataSet = new miPrimerProyectoCsharp.db_academicaDataSet();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasTableAdapter = new miPrimerProyectoCsharp.db_academicaDataSetTableAdapters.notasTableAdapter();
            this.tableAdapterManager = new miPrimerProyectoCsharp.db_academicaDataSetTableAdapters.TableAdapterManager();
            this.idNotaLabel1 = new System.Windows.Forms.Label();
            this.idAlumnoComboBox = new System.Windows.Forms.ComboBox();
            this.idPeriodoComboBox = new System.Windows.Forms.ComboBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            idNotaLabel = new System.Windows.Forms.Label();
            idAlumnoLabel = new System.Windows.Forms.Label();
            idPeriodoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // db_academicaDataSet
            // 
            this.db_academicaDataSet.DataSetName = "db_academicaDataSet";
            this.db_academicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "notas";
            this.notasBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alumnosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dnotasTableAdapter = null;
            this.tableAdapterManager.materiasTableAdapter = null;
            this.tableAdapterManager.notasTableAdapter = this.notasTableAdapter;
            this.tableAdapterManager.periodosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = miPrimerProyectoCsharp.db_academicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idNotaLabel
            // 
            idNotaLabel.AutoSize = true;
            idNotaLabel.Location = new System.Drawing.Point(34, 47);
            idNotaLabel.Name = "idNotaLabel";
            idNotaLabel.Size = new System.Drawing.Size(44, 13);
            idNotaLabel.TabIndex = 0;
            idNotaLabel.Text = "id Nota:";
            // 
            // idNotaLabel1
            // 
            this.idNotaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "idNota", true));
            this.idNotaLabel1.Location = new System.Drawing.Point(97, 47);
            this.idNotaLabel1.Name = "idNotaLabel1";
            this.idNotaLabel1.Size = new System.Drawing.Size(200, 23);
            this.idNotaLabel1.TabIndex = 1;
            this.idNotaLabel1.Text = "label1";
            // 
            // idAlumnoLabel
            // 
            idAlumnoLabel.AutoSize = true;
            idAlumnoLabel.Location = new System.Drawing.Point(34, 76);
            idAlumnoLabel.Name = "idAlumnoLabel";
            idAlumnoLabel.Size = new System.Drawing.Size(56, 13);
            idAlumnoLabel.TabIndex = 2;
            idAlumnoLabel.Text = "id Alumno:";
            // 
            // idAlumnoComboBox
            // 
            this.idAlumnoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "idAlumno", true));
            this.idAlumnoComboBox.FormattingEnabled = true;
            this.idAlumnoComboBox.Location = new System.Drawing.Point(97, 73);
            this.idAlumnoComboBox.Name = "idAlumnoComboBox";
            this.idAlumnoComboBox.Size = new System.Drawing.Size(200, 21);
            this.idAlumnoComboBox.TabIndex = 3;
            // 
            // idPeriodoLabel
            // 
            idPeriodoLabel.AutoSize = true;
            idPeriodoLabel.Location = new System.Drawing.Point(34, 103);
            idPeriodoLabel.Name = "idPeriodoLabel";
            idPeriodoLabel.Size = new System.Drawing.Size(57, 13);
            idPeriodoLabel.TabIndex = 4;
            idPeriodoLabel.Text = "id Periodo:";
            // 
            // idPeriodoComboBox
            // 
            this.idPeriodoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "idPeriodo", true));
            this.idPeriodoComboBox.FormattingEnabled = true;
            this.idPeriodoComboBox.Location = new System.Drawing.Point(97, 100);
            this.idPeriodoComboBox.Name = "idPeriodoComboBox";
            this.idPeriodoComboBox.Size = new System.Drawing.Size(200, 21);
            this.idPeriodoComboBox.TabIndex = 5;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(34, 131);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(37, 13);
            fechaLabel.TabIndex = 6;
            fechaLabel.Text = "fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(97, 127);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 7;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idNotaLabel);
            this.Controls.Add(this.idNotaLabel1);
            this.Controls.Add(idAlumnoLabel);
            this.Controls.Add(this.idAlumnoComboBox);
            this.Controls.Add(idPeriodoLabel);
            this.Controls.Add(this.idPeriodoComboBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_academicaDataSet db_academicaDataSet;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private db_academicaDataSetTableAdapters.notasTableAdapter notasTableAdapter;
        private db_academicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idNotaLabel1;
        private System.Windows.Forms.ComboBox idAlumnoComboBox;
        private System.Windows.Forms.ComboBox idPeriodoComboBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
    }
}