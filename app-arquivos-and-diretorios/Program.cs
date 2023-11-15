try
{
	StreamWriter sw =
		new StreamWriter(@"c:\temp\arquivo.txt", true);
	sw.WriteLine($"Terça-Feira: {DateTime.Now}");
	sw.Close();
}
catch (Exception ex)
{
	Console.WriteLine($"Erro: {ex.Message}");
}

try
{
	StreamReader sr =
		 new StreamReader(@"c:\temp\arquivo.txt");
	while (!sr.EndOfStream) { Console.WriteLine(sr.ReadLine()); }
	sr.Close();
}
catch (Exception ex)
{
	Console.WriteLine($"Erro:{ex.Message}"); ;
}

//using (StreamWriter sw =
//	new StreamWriter(@"c:\temp\arquivo.txt", true))
//{
//    sw.WriteLine($"Terça-Feira: {DateTime.Now}");
//}

//using StreamWriter sw =
//    new StreamWriter(@"c:\temp\arquivo.txt", true);
//    sw.WriteLine($"Terça-Feira: {DateTime.Now}");
