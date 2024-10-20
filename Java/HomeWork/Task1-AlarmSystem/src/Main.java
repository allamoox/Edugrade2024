import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        AlarmSystem alarmSystem = new AlarmSystem();
        RandomEvents randomEvents = new RandomEvents();
        Scanner scanner = new Scanner(System.in);
        boolean exit = false;

        while (!exit) {
            System.out.println("1. Activate Alarm");
            System.out.println("2. Deactivate Alarm");
            System.out.println("3. Simulate Fire");
            System.out.println("4. Simulate Burglary");
            System.out.println("5. Exit");
            int choice = scanner.nextInt();

            switch (choice) {
                case 1:
                    alarmSystem.activateAlarm();
                    break;
                case 2:
                    alarmSystem.deactivateAlarm();
                    break;
                case 3:
                    if (randomEvents.simulateFire()) {
                        alarmSystem.fire = true;
                        alarmSystem.checkSensor();
                    } else {
                        System.out.println("No fire detected.");
                    }
                    break;
                case 4:
                    if (randomEvents.simulateBurglary()) {
                        alarmSystem.burglary = true;
                        alarmSystem.checkSensor();
                    } else {
                        System.out.println("No burglary detected.");
                    }
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    System.out.println("Invalid choice, try again.");
            }
        }

        scanner.close();
    }
}
