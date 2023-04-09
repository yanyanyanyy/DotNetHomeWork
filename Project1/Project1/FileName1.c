#include <stdio.h>
#include <stdlib.h>
#include <winsock2.h>
#include <ws2tcpip.h>
#pragma comment(lib, "Ws2_32.lib")

#define DEFAULT_PORT "8888"
#define DEFAULT_BUFLEN 1024

int main(int argc, char** argv) {
    WSADATA wsaData;
    SOCKET listenSocket = INVALID_SOCKET, clientSocket = INVALID_SOCKET;
    struct addrinfo* result = NULL, hints;
    int iResult;
    char recvbuf[DEFAULT_BUFLEN];
    int recvbuflen = DEFAULT_BUFLEN;

    // ��ʼ�� Winsock
    iResult = WSAStartup(MAKEWORD(2, 2), &wsaData);
    if (iResult != 0) {
        printf("WSAStartup ʧ��: %d\n", iResult);
        return 1;
    }

    ZeroMemory(&hints, sizeof(hints));
    hints.ai_family = AF_INET;
    hints.ai_socktype = SOCK_STREAM;
    hints.ai_protocol = IPPROTO_TCP;
    hints.ai_flags = AI_PASSIVE;

    // ������������ַ�Ͷ˿ں�
    iResult = getaddrinfo(NULL, DEFAULT_PORT, &hints, &result);
    if (iResult != 0) {
        printf("getaddrinfo ʧ��: %d\n", iResult);
        WSACleanup();
        return 1;
    }

    // ��������socket
    listenSocket = socket(result->ai_family, result->ai_socktype, result->ai_protocol);
    if (listenSocket == INVALID_SOCKET) {
        printf("socket ʧ��: %ld\n", WSAGetLastError());
        freeaddrinfo(result);
        WSACleanup();
        return 1;
    }

    // ��socket�����ص�ַ�Ͷ˿�
    if (bind(listenSocket, result->ai_addr, (int)result->ai_addrlen) == SOCKET_ERROR) {
        printf("bind ʧ��: %d\n", WSAGetLastError());
        freeaddrinfo(result);
        closesocket(listenSocket);
        WSACleanup();
        return 1;
    }

    freeaddrinfo(result);

    // ��ʼ�������Կͻ��˵���������
    if (listen(listenSocket, SOMAXCONN) == SOCKET_ERROR) {
        printf("listen ʧ��: %d\n", WSAGetLastError());
        closesocket(listenSocket);
        WSACleanup();
        return 1;
    }

    printf("�ȴ��ͻ�������...\n");

    // �ȴ��ͻ�������
    clientSocket = accept(listenSocket, NULL, NULL);
    if (clientSocket == INVALID_SOCKET) {
        printf("accept ʧ��: %d\n", WSAGetLastError());
        closesocket(listenSocket);
        WSACleanup();
        return 1;
    }

    printf("�ͻ��������ӣ�\n");

    // ѭ�����պ�ת������
    while (1) {
        iResult = recv(clientSocket, recvbuf, recvbuflen, 0);
        if (iResult > 0) {
            printf("���յ����ݣ�%s\n", recvbuf);

            // ������Զ��յ������ݽ��д���

            // ת�����ݸ��������ӵĿͻ��ˣ������������ߣ�
            for (SOCKET i = listenSocket + 1; i <= FD_SETSIZE; i++) {
                if (FD_ISSET(i)) {
                    if (i != clientSocket) {
                        send(i, recvbuf, iResult, 0);
                    }
                }
            }

        }
        else if (iResult == 0) {
            printf("�����ѶϿ���\n");
            break;
        }
        else {
            printf("�������ݳ���%d\n", WSAGetLastError());
            break;
        }
    }

    // �ر�socket������Winsock
    closesocket(clientSocket);
    WSACleanup();

    return 0;
}