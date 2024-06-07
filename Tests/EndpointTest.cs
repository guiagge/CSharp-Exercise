namespace Tests;
using Xunit;

public class EndpointTest {
    [Fact]
    public void Constructor_SetsSerialNumber() {
        // Arrange
        string expectedSerialNumber = "ABC123";

        // Act
        var endpoint = new Endpoint(expectedSerialNumber);

        // Assert
        Assert.Equal(expectedSerialNumber, endpoint.getSerialNumber());
    }

    [Fact]
    public void Setters_UpdateProperties() {
        // Arrange
        var endpoint = new Endpoint("initial");

        // Act
        string newSerialNumber = "ASD";
        int newModelId = 16;
        int newMeterNumber = 1;
        string newFirmwareVersion = "1";
        int newSwitchState = 1;

        endpoint.setSerialNumber(newSerialNumber);
        endpoint.setModelId(newModelId);
        endpoint.setMeterNumber(newMeterNumber);
        endpoint.setFirmwareVersion(newFirmwareVersion);
        endpoint.setSwitchState(newSwitchState);

        // Assert
        Assert.Equal(newSerialNumber, endpoint.getSerialNumber());
        Assert.Equal(newModelId, endpoint.getModelId());
        Assert.Equal(newMeterNumber, endpoint.getMeterNumber());
        Assert.Equal(newFirmwareVersion, endpoint.getFirmwareVersion());
        Assert.Equal(0, endpoint.getSwitchState());
    }
}