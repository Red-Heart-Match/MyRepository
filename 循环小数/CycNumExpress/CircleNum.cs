using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycNumExpress
{
    /// <summary>
    /// 此类用来描述无限循环小数，拥有循环小数和分数两个属性
    /// </summary>
    public class CircleNum
    {
        string circNum; //循环小数
        public string CircNum
        {
            get { return circNum; }
            set { circNum = value; }
        }
        string fraction; //循环小数的分数表示

        public string Fraction
        {
            get { return fraction; }
            set { circNum = value; }
        }

        public CircleNum()
        {
        }

        public CircleNum(string circNum)
        {
            this.circNum = circNum;
            fraction = ChangeToFraction();
        }

        /// <summary>
        /// 此方法用来将无限循环小数转换成分数表示
        /// </summary>
        /// <returns>无限循环小数的分数表示</returns>
        public string ChangeToFraction()
        {
            string circBody; //循环体
            string acycBody; //非循环体
            int num;         //记录循环体前面小数点的位数
            string fraction;//分数

            circBody = GetCircBody(circNum);//获取循环体
            acycBody = GetAcycBody(circNum);//获取非循环体
            //获取循环体前的小数位数，如 1.13(3)其num的值为1
            num = GetBCirBodyDecimal(circNum);
            fraction = GetFraction(circBody, acycBody, num);//获取分数表示
            return fraction;
        }

        /// <summary>
        /// 此函数用来获取循环体，如1.13(3)，则获取值为3
        /// </summary>
        /// <param name="circNum">循环小数</param>
        /// <returns>循环体</returns>
        public string GetCircBody(String circNum)
        {
            string circBody = "0";
            int firstIndex = circNum.IndexOf("(") + 1; //读的首位置下标
            int lastIndex = circNum.LastIndexOf(")") - 1;//读取的尾下标
            int readNum = lastIndex - firstIndex + 1;//读取的数目
            if ((firstIndex > 0) && readNum > 0)
            {
                circBody = circNum.Substring(firstIndex, readNum);//截取循环体
            }
            return circBody;
        }
        /// <summary>
        /// 此函数用来获取非循环体，如1.13(3)，则获取值为1.1
        /// </summary>
        /// <param name="circNum">循环小数</param>
        /// <returns>非循环体</returns>
        public string GetAcycBody(String circNum)
        {
            string acycBody = "";
            int firstIndex = 0; //读的首位置下标
            int lastIndex = circNum.LastIndexOf(GetCircBody(circNum) + "(") - 1;//读取的尾下标
            int readNum = lastIndex - firstIndex + 1;//读取的数目
            if (firstIndex != -1 && readNum > 0)
            {
                acycBody = circNum.Substring(firstIndex, readNum);//截取循环体
                if (acycBody.EndsWith("."))//如果小数点后没有数了，那么就截去小数点
                {
                    acycBody = circNum.Substring(firstIndex, acycBody.Length - 1);//截取循环体
                }
            }
            else
            {
                acycBody = circNum;
            }
            return acycBody;
        }

        /// <summary>
        /// 此函数用来获取循环体前的小数位数，如 1.13(3)其num的值为1
        /// </summary>
        /// <param name="circNum">循环小数</param>
        /// <returns>循环体前的小数位数</returns>
        public int GetBCirBodyDecimal(String circNum)
        {
            int num = 0;
            string acycBody = GetAcycBody(circNum);
            int firstIndex = acycBody.IndexOf(".") + 1; //读的首位置下标
            int lastIndex = acycBody.Length - 1;//读取的尾下标
            int readNum = lastIndex - firstIndex + 1;//读取的数目
            if ((firstIndex > 0) && (readNum > 0))
            {
                num = acycBody.Substring(firstIndex, readNum).Length;//截取循环体
            }
            return num;
        }

        /// <summary>
        /// 此函数用来获取循环小数的分数表示
        /// </summary>
        /// <param name="circBody">循环体</param>
        /// <param name="acycBody">非循环体</param>
        /// <param name="num">循环体前的小数位</param>
        /// <returns>循环小数的分数表示</returns>
        public string GetFraction(string circBody, string acycBody, int num)
        {
            string fraction;
            long mol;         //分子
            long deno = 0;    //分母
            string op = "";
            if (int.Parse(circBody) == 0)
            {
                deno = 1;
            }
            else
            {
                for (int i = 1; i <= circBody.Length; ++i)
                    deno = deno * 10 + 9;
            }
            deno = deno * (int)Math.Pow(10, num);//为分母赋值
            mol = long.Parse(circBody) + (long)(Math.Abs(decimal.Parse(acycBody) * deno));//为分子赋值
            if (acycBody.Substring(0, 1) == "-")//记录循环小数的符号
            {
                op = "-";
            }
            long gcd = FindGCD(mol, deno);//寻找最大公约数
            fraction = op + (mol / gcd).ToString() + ((deno / gcd == 1) ? "" : "/" + (deno / gcd).ToString());//得到最简分数
            return fraction;
        }

        /// <summary>
        /// 本函数用辗转相除法来求解最大公约数
        /// </summary>
        /// <param name="num1">整数1</param>
        /// <param name="num2">整数2</param>
        /// <returns>最大公约数</returns>
        public long FindGCD(long num1, long num2)
        {
            long temp;
            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);
            temp = num1 % num2;
            while (temp != 0)
            {
                num1 = num2;
                num2 = temp;
                temp = num1 % num2;
            }
            return num2;
        }
    }
}
