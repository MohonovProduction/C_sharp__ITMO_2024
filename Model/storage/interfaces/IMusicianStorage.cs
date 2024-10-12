namespace Model.storage.interfaces;

public interface IMusicianStorage
{
    Task CreateMusicianAsync(Musician musician, List<int> instruments, CancellationToken cancellationToken);
    Task<Musician> ReadMusicianAsync(string id, CancellationToken cancellationToken);
    Task<Musician> UpdateMusicianAsync(Musician musician, CancellationToken cancellationToken);
    Task DeleteMusicianAsync(string id, CancellationToken cancellationToken);
    Task<IReadOnlyCollection<Musician>> ReadMusiciansAsync(CancellationToken cancellationToken);
}