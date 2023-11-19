namespace Simplz.Speedometer.Services;

internal interface ILocationService
{
    public Task<Location?> GetCurrentLocation(
        GeolocationAccuracy accuracy = GeolocationAccuracy.Default,
        CancellationToken cancellationToken = default);

    public Task<Location?> GetLastKnownLocation(CancellationToken cancellationToken = default);
}
