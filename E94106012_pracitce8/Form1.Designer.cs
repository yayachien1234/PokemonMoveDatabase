namespace E94106012_pracitce8
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.database1DataSet6 = new E94106012_pracitce8.Database1DataSet6();
            this.寶可夢_招式TableAdapter1 = new E94106012_pracitce8.Database1DataSet6TableAdapters.寶可夢_招式TableAdapter();
            this.招式_屬性_威力TableAdapter1 = new E94106012_pracitce8.Database1DataSet6TableAdapters.招式_屬性_威力TableAdapter();
            this.屬性_克制屬性_被克制屬性TableAdapter3 = new E94106012_pracitce8.Database1DataSet6TableAdapters.屬性_克制屬性_被克制屬性TableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet61 = new E94106012_pracitce8.Database1DataSet6();
            this.寶可夢招式BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.寶可夢DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.招式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.寶可夢招式招式屬性威力BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.招式DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.屬性DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.威力DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.招式屬性威力屬性克制屬性被克制屬性BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.屬性DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.克制屬性DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.被克制屬性DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.寶可夢招式BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.寶可夢招式招式屬性威力BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.招式屬性威力屬性克制屬性被克制屬性BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet6
            // 
            this.database1DataSet6.DataSetName = "Database1DataSet6";
            this.database1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 寶可夢_招式TableAdapter1
            // 
            this.寶可夢_招式TableAdapter1.ClearBeforeFill = true;
            // 
            // 招式_屬性_威力TableAdapter1
            // 
            this.招式_屬性_威力TableAdapter1.ClearBeforeFill = true;
            // 
            // 屬性_克制屬性_被克制屬性TableAdapter3
            // 
            this.屬性_克制屬性_被克制屬性TableAdapter3.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.database1DataSet6;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.寶可夢DataGridViewTextBoxColumn,
            this.招式DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.寶可夢招式BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(145, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet61
            // 
            this.database1DataSet61.DataSetName = "Database1DataSet6";
            this.database1DataSet61.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 寶可夢招式BindingSource
            // 
            this.寶可夢招式BindingSource.DataMember = "寶可夢_招式";
            this.寶可夢招式BindingSource.DataSource = this.database1DataSet61;
            // 
            // 寶可夢DataGridViewTextBoxColumn
            // 
            this.寶可夢DataGridViewTextBoxColumn.DataPropertyName = "寶可夢";
            this.寶可夢DataGridViewTextBoxColumn.HeaderText = "寶可夢";
            this.寶可夢DataGridViewTextBoxColumn.Name = "寶可夢DataGridViewTextBoxColumn";
            // 
            // 招式DataGridViewTextBoxColumn
            // 
            this.招式DataGridViewTextBoxColumn.DataPropertyName = "招式";
            this.招式DataGridViewTextBoxColumn.HeaderText = "招式";
            this.招式DataGridViewTextBoxColumn.Name = "招式DataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.招式DataGridViewTextBoxColumn1,
            this.屬性DataGridViewTextBoxColumn,
            this.威力DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.寶可夢招式招式屬性威力BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(145, 190);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // 寶可夢招式招式屬性威力BindingSource
            // 
            this.寶可夢招式招式屬性威力BindingSource.DataMember = "寶可夢_招式_招式_屬性_威力";
            this.寶可夢招式招式屬性威力BindingSource.DataSource = this.寶可夢招式BindingSource;
            // 
            // 招式DataGridViewTextBoxColumn1
            // 
            this.招式DataGridViewTextBoxColumn1.DataPropertyName = "招式";
            this.招式DataGridViewTextBoxColumn1.HeaderText = "招式";
            this.招式DataGridViewTextBoxColumn1.Name = "招式DataGridViewTextBoxColumn1";
            // 
            // 屬性DataGridViewTextBoxColumn
            // 
            this.屬性DataGridViewTextBoxColumn.DataPropertyName = "屬性";
            this.屬性DataGridViewTextBoxColumn.HeaderText = "屬性";
            this.屬性DataGridViewTextBoxColumn.Name = "屬性DataGridViewTextBoxColumn";
            // 
            // 威力DataGridViewTextBoxColumn
            // 
            this.威力DataGridViewTextBoxColumn.DataPropertyName = "威力";
            this.威力DataGridViewTextBoxColumn.HeaderText = "威力";
            this.威力DataGridViewTextBoxColumn.Name = "威力DataGridViewTextBoxColumn";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.屬性DataGridViewTextBoxColumn1,
            this.克制屬性DataGridViewTextBoxColumn,
            this.被克制屬性DataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.招式屬性威力屬性克制屬性被克制屬性BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(145, 357);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // 招式屬性威力屬性克制屬性被克制屬性BindingSource
            // 
            this.招式屬性威力屬性克制屬性被克制屬性BindingSource.DataMember = "招式_屬性_威力_屬性_克制屬性_被克制屬性";
            this.招式屬性威力屬性克制屬性被克制屬性BindingSource.DataSource = this.寶可夢招式招式屬性威力BindingSource;
            // 
            // 屬性DataGridViewTextBoxColumn1
            // 
            this.屬性DataGridViewTextBoxColumn1.DataPropertyName = "屬性";
            this.屬性DataGridViewTextBoxColumn1.HeaderText = "屬性";
            this.屬性DataGridViewTextBoxColumn1.Name = "屬性DataGridViewTextBoxColumn1";
            // 
            // 克制屬性DataGridViewTextBoxColumn
            // 
            this.克制屬性DataGridViewTextBoxColumn.DataPropertyName = "克制屬性";
            this.克制屬性DataGridViewTextBoxColumn.HeaderText = "克制屬性";
            this.克制屬性DataGridViewTextBoxColumn.Name = "克制屬性DataGridViewTextBoxColumn";
            // 
            // 被克制屬性DataGridViewTextBoxColumn
            // 
            this.被克制屬性DataGridViewTextBoxColumn.DataPropertyName = "被克制屬性";
            this.被克制屬性DataGridViewTextBoxColumn.HeaderText = "被克制屬性";
            this.被克制屬性DataGridViewTextBoxColumn.Name = "被克制屬性DataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.寶可夢招式BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.寶可夢招式招式屬性威力BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.招式屬性威力屬性克制屬性被克制屬性BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource 屬性克制屬性被克制屬性BindingSource;
        private Database1DataSet6 database1DataSet6;
        private Database1DataSet6TableAdapters.寶可夢_招式TableAdapter 寶可夢_招式TableAdapter1;
        private Database1DataSet6TableAdapters.招式_屬性_威力TableAdapter 招式_屬性_威力TableAdapter1;
        private Database1DataSet6TableAdapters.屬性_克制屬性_被克制屬性TableAdapter 屬性_克制屬性_被克制屬性TableAdapter3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet6 database1DataSet61;
        private System.Windows.Forms.BindingSource 寶可夢招式BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 寶可夢DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 招式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource 寶可夢招式招式屬性威力BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 招式DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 屬性DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 威力DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource 招式屬性威力屬性克制屬性被克制屬性BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 屬性DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 克制屬性DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 被克制屬性DataGridViewTextBoxColumn;
    }
}

