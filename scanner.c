#include <stdio.h>
#include <stdlib.h>

/**
 * BYTE-SIZE: System Scanner v0.1
 * Purpose: Direct system status check via C source.
 * No binaries allowed in repo.
 */

void check_battery() {
    printf("[SCANNING] Battery Status...\n");
    // On Linux/Android, this reads the system file directly
    system("cat /sys/class/power_supply/battery/capacity 2>/dev/null || echo 'Battery data unavailable on this OS'");
}

void check_cpu() {
    printf("[SCANNING] CPU Load...\n");
    system("uptime");
}

int main() {
    printf("--- BYTE-SIZE CORE ---\n");
    check_battery();
    check_cpu();
    printf("----------------------\n");
    printf("Scan Complete. Ready for next command.\n");
    return 0;
}
