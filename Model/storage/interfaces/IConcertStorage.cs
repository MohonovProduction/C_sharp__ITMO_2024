namespace Model.interfaces;

public interface IConcertStorage
{
    void Create();
    Concert Read();
    void Update();
    void Delete();
}