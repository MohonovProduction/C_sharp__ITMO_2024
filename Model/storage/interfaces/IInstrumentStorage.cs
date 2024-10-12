namespace Model.interfaces;

public interface IInstrumentStorage
{
    Task CreateInstrumentAsync(Instrument instrument, CancellationToken cancellationToken);
    Task<Instrument> ReadInstrumentAsync(string id, CancellationToken cancellationToken);
    Task<Instrument> UpdateInstrumentAsync(Instrument instrument, CancellationToken cancellationToken);
    Task DeleteInstrumentAsync(string id, CancellationToken cancellationToken);
    Task<IReadOnlyCollection<Instrument>> ReadInstrumentsAsync(CancellationToken cancellationToken);
}