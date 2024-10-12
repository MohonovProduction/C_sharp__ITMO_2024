using System.Text.Json;
using Model.interfaces;
using Model.storage;
using Model.storage.interfaces;

namespace Model.storage;

public class MusicianStorage : IMusicianStorage
{
    
    private IStorekeeper<Musician> _storekeeper;

    public MusicianStorage()
    {
        _storekeeper = new Storekeeper<Musician>("../../data/Musician.json", "musician");
    }

    public async Task CreateMusicianAsync(Musician musician, List<int> instruments, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        await _storekeeper.AddAsync(musician, cancellationToken);
    }

    public Task<Musician> ReadMusicianAsync(string id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Musician> UpdateMusicianAsync(Musician musician, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task DeleteMusicianAsync(string id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<Musician>> ReadMusiciansAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}