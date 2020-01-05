public int Persistence(long num)
        {
            try
            {
                int n = Convert.ToInt32(Math.Floor(Math.Log10(num) + 1));
                string numText = num.ToString();
                int count = 0;
                int value = 1;

                while ((n != 1) && (n != 0))
                {
                    char[] charArr = numText.ToCharArray();
                    foreach (var item in charArr)
                    {
                        value = Convert.ToInt32(item.ToString())* value;
                    }
                    n = (value == 0) ? (Convert.ToInt16(Math.Floor(Math.Log10(Convert.ToInt16(value) + 1)))) : (Convert.ToInt32(Math.Floor(Math.Log10(value) + 1)));
                    numText = value.ToString();
                    count++;
                    Array.Clear(charArr, 0, charArr.Length);
                    value = 1;
                    
                }
                MessageBox.Show(count.ToString());
                return n;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
