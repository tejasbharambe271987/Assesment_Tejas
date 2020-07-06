using System;
namespace AssesmentTejas.ViewModel
{
    public class DetailPageViewModel
    {
        public bool Validate_SA_ID(string id_num)
        {

            if (id_num == "0000000000000")
            {
                return false;
            }
            bool IsValid = false;
            if (id_num.Length == 13)
            {
                int c, odds, result1, result2, result3, dsada;
                odds = 0;
                result2 = 0;
                string evens = "";
                for (c = 0; c < 12; c++)
                {
                    if (c % 2 == 0)
                        odds += Convert.ToInt32(id_num.Substring(c, 1));
                    else
                        evens += id_num.Substring(c, 1);
                }
                result1 = Convert.ToInt32(evens) * 2;
                string res = result1.ToString();
                int k;
                for (k = 0; k < res.Length; k++)
                {
                    result2 += Convert.ToInt32(res.Substring(k, 1));
                }
                result3 = odds + result2;
                dsada = 10 - result3 % 10;
                if (dsada.ToString().Length == 1)
                {
                    if (Convert.ToInt32(id_num.Substring(12)) == dsada)
                    {
                        IsValid = true;
                    }
                    else
                        IsValid = false;

                }
                else
                {
                    if (dsada.ToString().Substring(1, 1) == id_num.Substring(12, 1))
                    {
                        IsValid = true;
                    }
                    else
                    {
                        IsValid = false;

                    }
                }
            }
            return IsValid;

        }
    }
}
