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

    // 初始化 Winsock
    iResult = WSAStartup(MAKEWORD(2, 2), &wsaData);
    if (iResult != 0) {
        printf("WSAStartup 失败: %d\n", iResult);
        return 1;
    }

    ZeroMemory(&hints, sizeof(hints));
    hints.ai_family = AF_INET;
    hints.ai_socktype = SOCK_STREAM;
    hints.ai_protocol = IPPROTO_TCP;
    hints.ai_flags = AI_PASSIVE;

    // 解析服务器地址和端口号
    iResult = getaddrinfo(NULL, DEFAULT_PORT, &hints, &result);
    if (iResult != 0) {
        printf("getaddrinfo 失败: %d\n", iResult);
        WSACleanup();
        return 1;
    }

    // 创建监听socket
    listenSocket = socket(result->ai_family, result->ai_socktype, result->ai_protocol);
    if (listenSocket == INVALID_SOCKET) {
        printf("socket 失败: %ld\n", WSAGetLastError());
        freeaddrinfo(result);
        WSACleanup();
        return 1;
    }

    // 绑定socket到本地地址和端口
    if (bind(listenSocket, result->ai_addr, (int)result->ai_addrlen) == SOCKET_ERROR) {
        printf("bind 失败: %d\n", WSAGetLastError());
        freeaddrinfo(result);
        closesocket(listenSocket);
        WSACleanup();
        return 1;
    }

    freeaddrinfo(result);

    // 开始监听来自客户端的连接请求
    if (listen(listenSocket, SOMAXCONN) == SOCKET_ERROR) {
        printf("listen 失败: %d\n", WSAGetLastError());
        closesocket(listenSocket);
        WSACleanup();
        return 1;
    }

    printf("等待客户端连接...\n");

    // 等待客户端连接
    clientSocket = accept(listenSocket, NULL, NULL);
    if (clientSocket == INVALID_SOCKET) {
        printf("accept 失败: %d\n", WSAGetLastError());
        closesocket(listenSocket);
        WSACleanup();
        return 1;
    }

    printf("客户端已连接！\n");

    // 循环接收和转发数据
    while (1) {
        iResult = recv(clientSocket, recvbuf, recvbuflen, 0);
        if (iResult > 0) {
            printf("接收到数据：%s\n", recvbuf);

            // 这里可以对收到的数据进行处理

            // 转发数据给所有连接的客户端（不包括发送者）
            for (SOCKET i = listenSocket + 1; i <= FD_SETSIZE; i++) {
                if (FD_ISSET(i)) {
                    if (i != clientSocket) {
                        send(i, recvbuf, iResult, 0);
                    }
                }
            }

        }
        else if (iResult == 0) {
            printf("连接已断开。\n");
            break;
        }
        else {
            printf("接收数据出错：%d\n", WSAGetLastError());
            break;
        }
    }

    // 关闭socket和清理Winsock
    closesocket(clientSocket);
    WSACleanup();

    return 0;
}