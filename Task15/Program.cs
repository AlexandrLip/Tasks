
int num = new Random().Next(100,1000);
string numS = num.ToString();

int first = Convert.ToInt32(numS[0].ToString());
int Third = Convert.ToInt32(numS[2].ToString());

WriteLine(num);
Write(first);
Write(third);