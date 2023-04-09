#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>

// ����һ�����ݽṹ����ʾÿ���˿ڵ�״̬
typedef struct {
    int port_status;  //�˿�״̬��0��ʾδ���ӣ�1��ʾ�����ѽ���
    char mac_address[18];  //����˶˿������ӵ��豸��MAC��ַ
} PORT;

// ����һ�����ݽṹ����ʾת�����е�ÿ����Ŀ
typedef struct {
    char mac_address[18];  //Ŀ��MAC��ַ
    int port_number;  //��Ӧ�Ķ˿ں�
} FORWARDING_ENTRY;

// ����һ�����ݽṹ����ʾ����������
typedef struct {
    PORT ports[4];
    FORWARDING_ENTRY forwarding_table[100];
    int num_forwarding_entries;
} SWITCH;

// ����ת�������Ƿ����Ŀ��MAC��ַ�����ض�Ӧ�Ķ˿ں�
int find_port_number(SWITCH *switch_inst, char *mac_address) {
    int i;
    for (i = 0; i < switch_inst->num_forwarding_entries; i++) {
        if (strcmp(switch_inst->forwarding_table[i].mac_address, mac_address) == 0) {
            return switch_inst->forwarding_table[i].port_number;
        }
    }
    return -1;
}

// ��һ��֡��һ���˿ڷ��͵���һ���˿�
void forward_frame(SWITCH *switch_inst, char *frame, int in_port_number) {
    char dest_mac[18];
    strncpy(dest_mac, frame, 17);
    dest_mac[17] = '\0';

    int out_port_number = find_port_number(switch_inst, dest_mac);

    if (out_port_number == -1) {
        // Ŀ���ַ����ת�����У��㲥�����ж˿ڣ���������˿�
        int i;
        for (i = 0; i < 4; i++) {
            if (i != in_port_number && switch_inst->ports[i].port_status == 1) {
                printf("Broadcasting frame to port %d\n", i);
            }
        }
    } else {
        // Ŀ���ַ��ת�����У����͵���Ӧ�Ķ˿�
        printf("Forwarding frame from port %d to port %d\n", in_port_number, out_port_number);
    }
}

int main() {
    // ����һ�����������󲢳�ʼ��
    SWITCH switch_inst;
    memset(&switch_inst, 0, sizeof(SWITCH));

    // ����1�Ŷ˿������Ӳ�������MAC��ַ
    switch_inst.ports[0].port_status = 1;
    strcpy(switch_inst.ports[0].mac_address, "00:11:22:33:44:55");

    // ���һЩת������Ŀ
    switch_inst.forwarding_table[0].port_number = 1;
    strcpy(switch_inst.forwarding_table[0].mac_address, "aa:bb:cc:dd:ee:ff");
    switch_inst.num_forwarding_entries = 1;

    // ģ���2�Ŷ˿ڽ��յ�һ��֡
    char *frame = "aa:bb:cc:dd:ee:ff Hello, world!";
    forward_frame(&switch_inst, frame, 1);

    return 0;
}