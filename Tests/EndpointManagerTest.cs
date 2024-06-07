namespace Tests;
using Xunit;

public class EndpointManagerTests {
    [Fact]  // Tests if an duplicate endpoint can be created
    public void CreateDuplicateEndpoint() {
        // Arrange/Act
        var manager = new EndpointManager();
        string existingSerialNumber = "ASD";
        manager.createEndpoint();

        Console.SetIn(new StringReader($"{existingSerialNumber}\n17\n12345\nv1.2.3\n1"));
        manager.createEndpoint();

        // Assert
        Assert.Contains("This Serial Number is already being used", Console.Out.ToString());
    }

    [Fact]
    public void FindExistingEndpoint() {
        // Arrange/Act
        var manager = new EndpointManager();
        string expectedSerialNumber = "ASD";
        int expectedModelId = 16;
        int expectedMeterNumber = 1;
        string expectedFirmwareVersion = "1";
        int expectedSwitchState = 1;

        // Creates an endpoint with the information we want
        manager.createEndpoint();
        Console.SetIn(new StringReader($"{expectedSerialNumber}\n{expectedModelId}\n{expectedMeterNumber}\n{expectedFirmwareVersion}\n{expectedSwitchState}"));
        manager.createEndpoint();

        string searchValue = expectedSerialNumber;
        manager.findEndpoint(searchValue);

        // Assert
        Assert.Contains($"Endpoint Serial Number: {expectedSerialNumber}", Console.Out.ToString());
        Assert.Contains($"Meter Model Id: {expectedModelId}", Console.Out.ToString());
    }

    [Fact]
    public void FindImaginaryEndpoint() {
        // Arrange
        var manager = new EndpointManager();
        string nonExistentSerialNumber = "ZXC";

        // Act
        manager.findEndpoint(nonExistentSerialNumber);

        Assert.Contains("No endpoint could be found", Console.Out.ToString());
    }
}