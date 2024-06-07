// Endpoint class
class Endpoint {
    private string serialNumber, firmwareVersion;
    private int modelId, meterNumber, switchState;

    public Endpoint(string serialNumber) {
        this.serialNumber = serialNumber;
    }

    public string getSerialNumber() {
        return serialNumber;
    }

    public string getFirmwareVersion() {
        return firmwareVersion;
    }

    public int getModelId() {
        return modelId;
    }

    public int getMeterNumber() {
        return meterNumber;
    }

    public int getSwitchState() {
        return switchState;
    }

    public void setSerialNumber(string serialNumber) {
        this.serialNumber = serialNumber;
    }

    public void setFirmwareVersion(string firmwareVersion) {
        this.firmwareVersion = firmwareVersion;
    }

    public void setModelId(int modelId) {
        this.modelId = modelId;
    }

    public void setMeterNumber(int meterNumber) {
        this.meterNumber = meterNumber;
    }

    public void setSwitchState(int switchState) {
        this.switchState = switchState;
    }

    public void print() {
        Console.WriteLine("\nEndpoint Serial Number: " + serialNumber);
        Console.WriteLine("Meter Model Id: " + modelId);
        Console.WriteLine("Meter Number: " + meterNumber);
        Console.WriteLine("Firmware Version: " + firmwareVersion);
        Console.WriteLine("Switch State: " + switchState + "\n");
    }
}