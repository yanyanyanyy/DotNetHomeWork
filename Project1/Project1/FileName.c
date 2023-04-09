#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>

// 定义一个数据结构来表示每个端口的状态
typedef struct {
    int port_status;  //端口状态，0表示未连接，1表示连接已建立
    char mac_address[18];  //保存此端口所连接的设备的MAC地址
} PORT;

// 定义一个数据结构来表示转发表中的每个条目
typedef struct {
    char mac_address[18];  //目标MAC地址
    int port_number;  //对应的端口号
} FORWARDING_ENTRY;

// 定义一个数据结构来表示整个交换机
typedef struct {
    PORT ports[4];
    FORWARDING_ENTRY forwarding_table[100];
    int num_forwarding_entries;
} SWITCH;

// 查找转发表中是否存在目标MAC地址，返回对应的端口号
int find_port_number(SWITCH *switch_inst, char *mac_address) {
    int i;
    for (i = 0; i < switch_inst->num_forwarding_entries; i++) {
        if (strcmp(switch_inst->forwarding_table[i].mac_address, mac_address) == 0) {
            return switch_inst->forwarding_table[i].port_number;
        }
    }
    return -1;
}

// 将一个帧从一个端口发送到另一个端口
void forward_frame(SWITCH *switch_inst, char *frame, int in_port_number) {
    char dest_mac[18];
    strncpy(dest_mac, frame, 17);
    dest_mac[17] = '\0';

    int out_port_number = find_port_number(switch_inst, dest_mac);

    if (out_port_number == -1) {
        // 目标地址不在转发表中，广播到所有端口，除了输入端口
        int i;
        for (i = 0; i < 4; i++) {
            if (i != in_port_number && switch_inst->ports[i].port_status == 1) {
                printf("Broadcasting frame to port %d\n", i);
            }
        }
    } else {
        // 目标地址在转发表中，发送到相应的端口
        printf("Forwarding frame from port %d to port %d\n", in_port_number, out_port_number);
    }
}

int main() {
    // 创建一个交换机对象并初始化
    SWITCH switch_inst;
    memset(&switch_inst, 0, sizeof(SWITCH));

    // 设置1号端口已连接并保存其MAC地址
    switch_inst.ports[0].port_status = 1;
    strcpy(switch_inst.ports[0].mac_address, "00:11:22:33:44:55");

    // 添加一些转发表条目
    switch_inst.forwarding_table[0].port_number = 1;
    strcpy(switch_inst.forwarding_table[0].mac_address, "aa:bb:cc:dd:ee:ff");
    switch_inst.num_forwarding_entries = 1;

    // 模拟从2号端口接收到一个帧
    char *frame = "aa:bb:cc:dd:ee:ff Hello, world!";
    forward_frame(&switch_inst, frame, 1);

    return 0;
}