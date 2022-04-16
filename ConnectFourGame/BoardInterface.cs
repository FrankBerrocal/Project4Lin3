using System;
namespace ConnectFourGame
{
    public interface BoardInterface
    {
        void Initiate();
        void SetColor(char c);
        void Display();
    }
}
