public void MakeMove()
{
  int thisTurnAnswer = 0;
  Console.Write("Enter your guess:");
  while (true)
  {
    string? input = Console.ReadLine();
    if (int.TryParse(input, out int answer))
    {
      if (100 <= answer && answer <= 999)
      {
        thisTurnAnswer = answer;
        break;
      }
    }
    else
    {
      Console.WriteLine("整数値を3桁で入力してください");
      Console.Write("Enter your guess:");
    }
  }
}