from PIL import Image

# 打开图片
img = Image.open("testi_avatar_01.png")
# 缩小图片 (宽100px，高自动计算)
img = img.resize((100, int(img.height * 100 / img.width)))
# 保存图片
img.save("small-image02.png")
