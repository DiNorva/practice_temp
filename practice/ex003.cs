/* ...

* Расстояние между двумя точками

*/
//           
double[] x = {5, 5};
double[] y = {0, 0};

double ab = x[0] - y[0];
double ac = x[1] - y[1];
var d = Math.Sqrt (ab * ab + ac * ac);
Concole.WriteLine($"d = {d}");
