namespace Exec2_TextBox_Q4
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.introPeople = new System.Windows.Forms.Label();
			this.introCar = new System.Windows.Forms.Label();
			this.btnResult = new System.Windows.Forms.Button();
			this.txtPeople = new System.Windows.Forms.TextBox();
			this.txtCar = new System.Windows.Forms.TextBox();
			this.result = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// introPeople
			// 
			this.introPeople.AutoSize = true;
			this.introPeople.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.introPeople.Location = new System.Drawing.Point(31, 23);
			this.introPeople.Name = "introPeople";
			this.introPeople.Size = new System.Drawing.Size(93, 20);
			this.introPeople.TabIndex = 0;
			this.introPeople.Text = "請輸入人數:";
			// 
			// introCar
			// 
			this.introCar.AutoSize = true;
			this.introCar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.introCar.Location = new System.Drawing.Point(31, 67);
			this.introCar.Name = "introCar";
			this.introCar.Size = new System.Drawing.Size(109, 20);
			this.introCar.TabIndex = 1;
			this.introCar.Text = "請輸入車輛數:";
			// 
			// btnResult
			// 
			this.btnResult.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnResult.Location = new System.Drawing.Point(335, 45);
			this.btnResult.Name = "btnResult";
			this.btnResult.Size = new System.Drawing.Size(75, 23);
			this.btnResult.TabIndex = 2;
			this.btnResult.Text = "Go!";
			this.btnResult.UseVisualStyleBackColor = true;
			this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
			// 
			// txtPeople
			// 
			this.txtPeople.Location = new System.Drawing.Point(170, 21);
			this.txtPeople.Name = "txtPeople";
			this.txtPeople.Size = new System.Drawing.Size(100, 22);
			this.txtPeople.TabIndex = 3;
			// 
			// txtCar
			// 
			this.txtCar.Location = new System.Drawing.Point(170, 66);
			this.txtCar.Name = "txtCar";
			this.txtCar.Size = new System.Drawing.Size(100, 22);
			this.txtCar.TabIndex = 4;
			// 
			// result
			// 
			this.result.AutoSize = true;
			this.result.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.result.Location = new System.Drawing.Point(30, 172);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(71, 27);
			this.result.TabIndex = 5;
			this.result.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 323);
			this.Controls.Add(this.result);
			this.Controls.Add(this.txtCar);
			this.Controls.Add(this.txtPeople);
			this.Controls.Add(this.btnResult);
			this.Controls.Add(this.introCar);
			this.Controls.Add(this.introPeople);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label introPeople;
		private System.Windows.Forms.Label introCar;
		private System.Windows.Forms.Button btnResult;
		private System.Windows.Forms.TextBox txtPeople;
		private System.Windows.Forms.TextBox txtCar;
		private System.Windows.Forms.Label result;
	}
}

