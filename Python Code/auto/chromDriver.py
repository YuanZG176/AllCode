from selenium import webdriver

driver = webdriver.Chrome()  # 如果配置了环境变量
# 或者指定路径：
# driver = webdriver.Chrome(executable_path="C:\\WebDriver\\chromedriver.exe")

driver.get("https://www.google.com")
print("Title is:", driver.title)
driver.quit()
