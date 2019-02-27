using System;
using System.Windows.Forms;

namespace ArithmeticCalc
{
    /// <summary>
    /// 四則演算サンプル。
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ArithmeticCalc : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArithmeticCalc"/> class.
        /// </summary>
        public ArithmeticCalc()
        {
            InitializeComponent();
        }

        // 加算の場合だけ入力値のチェック処理を追加しています。
        // その他のパターンについても、実行時にエラーを出さずに穏便に動かすための工夫をしてみましょう。

        /// <summary>
        /// テキストボックスの数値2つを加算。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // TryParseを使って変換可能かチェックしながら文字→整数変換を行う
            // このパターンだと、文字や空の場合も安心です
            int parseResult1, parseResult2 = 0;
            if (int.TryParse(TextValue1.Text, out parseResult1))
            {
                // 1つ目のテキストボックスが整数の場合→2つ目をチェック
                if (int.TryParse(TextValue2.Text, out parseResult2))
                {
                    // 2つとも整数であれば、TryParseの結果得られた数値で計算する
                    TextAnswer.Text = (parseResult1 + parseResult2).ToString();
                }
                else
                {
                    MessageBox.Show("2つ目の数値が整数ではありません。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("1つ目の数値が整数ではありません。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // チェック無しで整数として計算する場合はこちら
            //TextAnswer.Text = AddStringValues(TextValue1.Text, TextValue2.Text).ToString();

            // チェック無しで小数として計算する場合はこちら
            //TextAnswer.Text = AddStringValuesDouble(TextValue1.Text, TextValue2.Text).ToString();
        }

        /// <summary>
        /// テキストボックスの数値2つを減算。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void ButtonSub_Click(object sender, EventArgs e)
        {
            TextAnswer.Text = SubStringValues(TextValue1.Text, TextValue2.Text).ToString();
        }

        /// <summary>
        /// テキストボックスの数値2つを乗算。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void ButtonMult_Click(object sender, EventArgs e)
        {
            TextAnswer.Text=MultStringValues(TextValue1.Text, TextValue2.Text).ToString();
        }

        /// <summary>
        /// テキストボックスの数値2つを除算。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            TextAnswer.Text=DivStringValues(TextValue1.Text, TextValue2.Text).ToString();
        }

        /// <summary>
        /// 文字として渡された数値文字2個を加算して、int型で返す。
        /// </summary>
        /// <param name="valueString1">加算対象の値を表す「文字列」1。</param>
        /// <param name="valueString2">加算対象の値を表す「文字列」2。</param>
        /// <returns>加算した結果の数値（int型）。</returns>
        private int AddStringValues(string valueString1, string valueString2)
        {
            int result = 0;

            int value1 = int.Parse(valueString1);
            int value2 = int.Parse(valueString2);

            result = value1 + value2;

            return result;
        }

        /// <summary>
        /// 文字として渡された数値文字2個を加算して、double型で返す。
        /// </summary>
        /// <param name="valueString1">加算対象の値を表す「文字列」1。</param>
        /// <param name="valueString2">加算対象の値を表す「文字列」2。</param>
        /// <returns>加算した結果の数値（double型）。</returns>
        private double AddStringValuesDouble(string valueString1, string valueString2)
        {
            double result = 0;

            double value1 = double.Parse(valueString1);
            double value2 = double.Parse(valueString2);

            result = value1 + value2;

            return result;
        }

        /// <summary>
        /// 文字として渡された数値文字列2個を減算して、int型で返す。
        /// </summary>
        /// <param name="valueString1">減算される値を表す「文字列」1。</param>
        /// <param name="valueString2">減算する値を表す「文字列」2。</param>
        /// <returns>文字列1の値から文字列2の値を減算した結果の数値（int型）。</returns>
        private int SubStringValues(string valueString1, string valueString2)
        {
            int result = 0;

            int value1 = int.Parse(valueString1);
            int value2 = int.Parse(valueString2);

            result = value1 - value2;

            return result;
        }

        /// <summary>
        /// 文字として渡された数値文字列2個を乗算してdouble型で返す。
        /// </summary>
        /// <param name="valueString1">乗算する値を表す「文字列」1。</param>
        /// <param name="valueString2">乗算する値を表す「文字列」2。</param>
        /// <returns>文字列2の値と文字列2の値を乗算した結果の数値（double型）。</returns>
        private double MultStringValues(string valueString1, string valueString2)
        {
            double result = 0d;

            double value1 = double.Parse(valueString1);
            double value2 = double.Parse(valueString2);

            result = value1 * value2;

            return result;
        }

        /// <summary>
        /// 文字として渡された数値文字列2個を乗算して、double型で返す。
        /// </summary>
        /// <param name="valueString1">乗算される値を表す「文字列」1。</param>
        /// <param name="valueString2">乗算する値を表す「文字列」2。</param>
        /// <returns>文字列1の値を文字列2の値で割った結果の値（double型）。</returns>
        private double DivStringValues(string valueString1, string valueString2)
        {
            double result = 0d;

            double value1 = double.Parse(valueString1);
            double value2 = double.Parse(valueString2);

            result = value1 / value2;

            return result;
        }
    }
}
