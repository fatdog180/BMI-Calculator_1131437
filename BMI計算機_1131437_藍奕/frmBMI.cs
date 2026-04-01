using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI計算機_1131437_藍奕
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            bool isHeightValid = double.TryParse(txtHeight.Text, out double height);
            bool isWeightValid = double.TryParse(txtWeight.Text, out double weight);

            // 驗證身高
            if (!isHeightValid || height <= 0)
            {
                lblResult.Text = "請輸入有效的身高數值！";
                lblResult.BackColor = Color.LightPink; // 用粉紅色背景提示錯誤
                lblIdealWeight.Text = ""; // 清空理想體重
                return;
            }

            // 驗證體重
            if (!isWeightValid || weight <= 0)
            {
                lblResult.Text = "請輸入有效的體重數值！";
                lblResult.BackColor = Color.LightPink;
                lblIdealWeight.Text = "";
                return;
            }

            // 2. 計算 BMI
            // 將身高從公分轉換為公尺 [cite: 1220]
            height = height / 100;
            // BMI 計算公式為體重除以身高的平方 [cite: 1221, 1222]
            double bmi = weight / (height * height);

            // 3. 陣列宣告：儲存體位狀態與對應顏色 [cite: 1223, 1224, 1225]
            string[] strResultList = { "體重過輕", "健康體位", "體位過重", "輕度肥胖", "中度肥胖", "重度肥胖" };
            Color[] colorList = { Color.Blue, Color.Green, Color.Orange, Color.DarkOrange, Color.Red, Color.Purple };

            // 4. 判斷式：根據 BMI 數值找出對應的陣列索引 [cite: 1226, 1227, 1228, 1229, 1230, 1231, 1232, 1233, 1234, 1235, 1236, 1237, 1238, 1239]
            string strResult = "";
            Color colorResult = Color.Black;
            int resultIndex = 0;

            if (bmi < 18.5)
            {
                resultIndex = 0;
            }
            else if (bmi < 24)
            {
                resultIndex = 1;
            }
            else if (bmi < 27)
            {
                resultIndex = 2;
            }
            else if (bmi < 30)
            {
                resultIndex = 3;
            }
            else if (bmi < 35)
            {
                resultIndex = 4;
            }
            else
            {
                resultIndex = 5;
            }

            // 5. 輸出結果與格式化字串 [cite: 1240, 1241, 1242]
            strResult = strResultList[resultIndex];
            colorResult = colorList[resultIndex];
            // 使用 F2 讓小數點固定顯示兩位 [cite: 1168, 1169]
            lblResult.Text = $"{bmi:F2} ({strResult})";
            lblResult.BackColor = colorResult;

            // 1. 計算理想體重範圍 (以 BMI 18.5 ~ 24 為標準)
            double minWeight = 18.5 * (height * height);
            double maxWeight = 24 * (height * height);
            lblIdealWeight.Text = $"{minWeight:F1} ~ {maxWeight:F1} kg";

            // 2. 將這次的計算結果加入到歷史紀錄清單中
            // 取得現在時間，讓紀錄看起來更專業
            string timeNow = DateTime.Now.ToString("HH:mm:ss");
            string record = $"[{timeNow}] 身高:{txtHeight.Text}cm 體重:{txtWeight.Text}kg ➔ BMI:{bmi:F2} ({strResult})";
            lstHistory.Items.Add(record);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 將輸入焦點放回身高文字方塊
            txtHeight.Focus();

            // 清空輸入框
            txtHeight.Clear();
            txtWeight.Clear();

            // 清空輸出標籤與背景色
            lblResult.Text = "";
            lblResult.BackColor = SystemColors.Control;
            lblIdealWeight.Text = "";

            // 清空歷史紀錄
            lstHistory.Items.Clear();
        }
    }
}
