# RC4 Encryption Tool - Nhóm 8

Ứng dụng mã hoá RC4 (Rivest Cipher 4) được phát triển bằng C# Windows Forms.

## Tính năng

- Nhập văn bản gốc (Plaintext) và khoá (Key)
- Mã hoá văn bản bằng thuật toán RC4
- Hiển thị kết quả mã hoá dưới dạng Hex (CyberText)

## Cách chạy ứng dụng

1. Mở file `RC4-MMT-NHOM 8.sln` bằng Visual Studio
2. Build và chạy ứng dụng (F5)

---

## Khởi động lại SSH trên Ubuntu

Nếu cần khởi động lại dịch vụ SSH trên Ubuntu, sử dụng một trong các lệnh sau:

```bash
# Khởi động lại SSH (Ubuntu 16.04 trở lên)
sudo systemctl restart ssh

# Kiểm tra trạng thái SSH
sudo systemctl status ssh

# Dừng SSH
sudo systemctl stop ssh

# Khởi động SSH
sudo systemctl start ssh
```

Nếu sử dụng Ubuntu phiên bản cũ (trước 16.04):

```bash
sudo service ssh restart
```

Để bật SSH tự động khởi động cùng hệ thống:

```bash
sudo systemctl enable ssh
```
