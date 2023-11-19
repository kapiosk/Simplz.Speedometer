namespace Simplz.Speedometer.Services;

internal class LocationService : ILocationService
{
    public async Task<Location?> GetCurrentLocation(
        GeolocationAccuracy accuracy = GeolocationAccuracy.Default,
        CancellationToken cancellationToken = default)
    {
        var request = new GeolocationRequest(accuracy);
        return await Geolocation.GetLocationAsync(request, cancellationToken);
    }

    public async Task<Location?> GetLastKnownLocation(CancellationToken cancellationToken = default)
    {
        return await Geolocation.GetLastKnownLocationAsync();
    }
}
