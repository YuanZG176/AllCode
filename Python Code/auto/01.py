# coding:utf-8

import pywifi
from pywifi import const
import time

def wifiConnect(pwd):
    # 初始化PyWiFi对象
    wifi = pywifi.PyWiFi()

    # 获取第一个无线网卡接口
    ifaces = wifi.interfaces()[0]

    # 断开所有现有连接
    ifaces.disconnect()
    time.sleep(1)

    # 检查当前网卡状态，确认是否已断开
    wifistatus = ifaces.status()
    if wifistatus == const.IFACE_DISCONNECTED:
        # 创建新的WiFi连接配置文件
        profile = pywifi.Profile()

        # 设置要连接的WiFi名称（SSID）
        profile.ssid = "Suzhou Centennial College"

        # 设置WiFi的认证方式为开放式
        profile.auth = const.AUTH_ALG_OPEN

        # 设置WiFi加密算法（通常为 WPA2-PSK）
        profile.akm.append(const.AKM_TYPE_WPA2PSK)

        # 设置加密类型（通常使用CCMP）
        profile.cipher = const.CIPHER_TYPE_CCMP

        # 设置WiFi密码
        profile.key = pwd

        # 删除所有已存的WiFi配置文件
        ifaces.remove_all_network_profiles()

        # 将新的WiFi配置文件加载到网卡接口
        ifaces.add_network_profile(profile)

        # 尝试连接WiFi
        ifaces.connect(profile)
        time.sleep(5)

        # 获取连接状态
        wifistatus = ifaces.status()

        if wifistatus == const.IFACE_CONNECTED:
            print("连接成功！")
        else:
            print("连接失败！")
    else:
        print("当前网卡未断开，无法进行连接！")

# 调用函数并传入WiFi密码
wifiConnect("your_wifi_password")
