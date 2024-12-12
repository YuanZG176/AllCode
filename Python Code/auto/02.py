from PIL import Image, ImageDraw

# 打开图片
img = Image.open("team04.png")
width, height = img.size

# 创建一个透明背景的图片
output = Image.new("RGBA", (width, height), (0, 0, 0, 0))

# 计算圆形的边界
circle_radius = min(width, height) // 2
center = (width // 2, height // 2)

# 绘制圆形
draw = ImageDraw.Draw(output)
draw.ellipse((center[0] - circle_radius, center[1] - circle_radius,
              center[0] + circle_radius, center[1] + circle_radius), fill=(255, 255, 255, 255))

# 将原图粘贴到透明背景的圆形区域内
output.paste(img, (0, 0), mask=output)

# 保存结果
output.save("team4.png")
