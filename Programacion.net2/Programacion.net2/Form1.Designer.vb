<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Cod_aluLabel As System.Windows.Forms.Label
        Dim Nom_aluLabel As System.Windows.Forms.Label
        Dim Ape_aluLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Trabajo_2DataSet = New Programacion.net2.trabajo_2DataSet()
        Me.Otro_alumnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Otro_alumnoTableAdapter = New Programacion.net2.trabajo_2DataSetTableAdapters.otro_alumnoTableAdapter()
        Me.TableAdapterManager = New Programacion.net2.trabajo_2DataSetTableAdapters.TableAdapterManager()
        Me.Otro_alumnoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Otro_alumnoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Cod_aluTextBox = New System.Windows.Forms.TextBox()
        Me.Nom_aluTextBox = New System.Windows.Forms.TextBox()
        Me.Ape_aluTextBox = New System.Windows.Forms.TextBox()
        Me.Otro_alumnoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Cod_aluLabel = New System.Windows.Forms.Label()
        Nom_aluLabel = New System.Windows.Forms.Label()
        Ape_aluLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Trabajo_2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Otro_alumnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Otro_alumnoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Otro_alumnoBindingNavigator.SuspendLayout()
        CType(Me.Otro_alumnoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(442, 260)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Cod_aluLabel)
        Me.TabPage1.Controls.Add(Me.Cod_aluTextBox)
        Me.TabPage1.Controls.Add(Nom_aluLabel)
        Me.TabPage1.Controls.Add(Me.Nom_aluTextBox)
        Me.TabPage1.Controls.Add(Ape_aluLabel)
        Me.TabPage1.Controls.Add(Me.Ape_aluTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(434, 234)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Otro_alumnoDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(434, 234)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Trabajo_2DataSet
        '
        Me.Trabajo_2DataSet.DataSetName = "trabajo_2DataSet"
        Me.Trabajo_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Otro_alumnoBindingSource
        '
        Me.Otro_alumnoBindingSource.DataMember = "otro_alumno"
        Me.Otro_alumnoBindingSource.DataSource = Me.Trabajo_2DataSet
        '
        'Otro_alumnoTableAdapter
        '
        Me.Otro_alumnoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.otro_alumnoTableAdapter = Me.Otro_alumnoTableAdapter
        Me.TableAdapterManager.UpdateOrder = Programacion.net2.trabajo_2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Otro_alumnoBindingNavigator
        '
        Me.Otro_alumnoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Otro_alumnoBindingNavigator.BindingSource = Me.Otro_alumnoBindingSource
        Me.Otro_alumnoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Otro_alumnoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Otro_alumnoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Otro_alumnoBindingNavigatorSaveItem})
        Me.Otro_alumnoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Otro_alumnoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Otro_alumnoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Otro_alumnoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Otro_alumnoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Otro_alumnoBindingNavigator.Name = "Otro_alumnoBindingNavigator"
        Me.Otro_alumnoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Otro_alumnoBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Otro_alumnoBindingNavigator.TabIndex = 1
        Me.Otro_alumnoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'Otro_alumnoBindingNavigatorSaveItem
        '
        Me.Otro_alumnoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Otro_alumnoBindingNavigatorSaveItem.Image = CType(resources.GetObject("Otro_alumnoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Otro_alumnoBindingNavigatorSaveItem.Name = "Otro_alumnoBindingNavigatorSaveItem"
        Me.Otro_alumnoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Otro_alumnoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Cod_aluLabel
        '
        Cod_aluLabel.AutoSize = True
        Cod_aluLabel.Location = New System.Drawing.Point(48, 41)
        Cod_aluLabel.Name = "Cod_aluLabel"
        Cod_aluLabel.Size = New System.Drawing.Size(45, 13)
        Cod_aluLabel.TabIndex = 0
        Cod_aluLabel.Text = "cod alu:"
        '
        'Cod_aluTextBox
        '
        Me.Cod_aluTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Otro_alumnoBindingSource, "cod_alu", True))
        Me.Cod_aluTextBox.Location = New System.Drawing.Point(101, 41)
        Me.Cod_aluTextBox.Name = "Cod_aluTextBox"
        Me.Cod_aluTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cod_aluTextBox.TabIndex = 1
        '
        'Nom_aluLabel
        '
        Nom_aluLabel.AutoSize = True
        Nom_aluLabel.Location = New System.Drawing.Point(48, 70)
        Nom_aluLabel.Name = "Nom_aluLabel"
        Nom_aluLabel.Size = New System.Drawing.Size(47, 13)
        Nom_aluLabel.TabIndex = 2
        Nom_aluLabel.Text = "nom alu:"
        '
        'Nom_aluTextBox
        '
        Me.Nom_aluTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Otro_alumnoBindingSource, "nom_alu", True))
        Me.Nom_aluTextBox.Location = New System.Drawing.Point(101, 67)
        Me.Nom_aluTextBox.Name = "Nom_aluTextBox"
        Me.Nom_aluTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nom_aluTextBox.TabIndex = 3
        '
        'Ape_aluLabel
        '
        Ape_aluLabel.AutoSize = True
        Ape_aluLabel.Location = New System.Drawing.Point(48, 96)
        Ape_aluLabel.Name = "Ape_aluLabel"
        Ape_aluLabel.Size = New System.Drawing.Size(45, 13)
        Ape_aluLabel.TabIndex = 4
        Ape_aluLabel.Text = "ape alu:"
        '
        'Ape_aluTextBox
        '
        Me.Ape_aluTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Otro_alumnoBindingSource, "ape_alu", True))
        Me.Ape_aluTextBox.Location = New System.Drawing.Point(101, 93)
        Me.Ape_aluTextBox.Name = "Ape_aluTextBox"
        Me.Ape_aluTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Ape_aluTextBox.TabIndex = 5
        '
        'Otro_alumnoDataGridView
        '
        Me.Otro_alumnoDataGridView.AutoGenerateColumns = False
        Me.Otro_alumnoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Otro_alumnoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Otro_alumnoDataGridView.DataSource = Me.Otro_alumnoBindingSource
        Me.Otro_alumnoDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Otro_alumnoDataGridView.Name = "Otro_alumnoDataGridView"
        Me.Otro_alumnoDataGridView.Size = New System.Drawing.Size(434, 220)
        Me.Otro_alumnoDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cod_alu"
        Me.DataGridViewTextBoxColumn1.HeaderText = "cod_alu"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nom_alu"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nom_alu"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ape_alu"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ape_alu"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Otro_alumnoBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Trabajo_2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Otro_alumnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Otro_alumnoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Otro_alumnoBindingNavigator.ResumeLayout(False)
        Me.Otro_alumnoBindingNavigator.PerformLayout()
        CType(Me.Otro_alumnoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Trabajo_2DataSet As trabajo_2DataSet
    Friend WithEvents Otro_alumnoBindingSource As BindingSource
    Friend WithEvents Otro_alumnoTableAdapter As trabajo_2DataSetTableAdapters.otro_alumnoTableAdapter
    Friend WithEvents TableAdapterManager As trabajo_2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Otro_alumnoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Otro_alumnoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Cod_aluTextBox As TextBox
    Friend WithEvents Nom_aluTextBox As TextBox
    Friend WithEvents Ape_aluTextBox As TextBox
    Friend WithEvents Otro_alumnoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
