using System;

class Player
{
  public string name;
  public bool isLocal;
  public bool isHost;
  public List<int> answerList;
  public int myAnswer;

  public Player(string name, bool isLocal, bool isHost, int myAnswer)
  {
    this.name = name;
    this.isLocal = isLocal;
    this.isHost = isHost;
    this.myAnswer = myAnswer;
    this.answerList = new List<int>();
  }
}