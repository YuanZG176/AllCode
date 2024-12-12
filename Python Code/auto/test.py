
import time
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys

# 初始化浏览器
driver = webdriver.Chrome()  # 确保安装了 ChromeDriver
driver.get('https://mooc1.chaoxing.com/mooc-ans/mooc2/work/dowork?courseId=244207727&classId=101087911&cpi=264770220&workId=39125691&answerId=54376376&standardEnc=317408b69138d8b34e06c00821820e4d&enc=bbec5a9459588e9976bfced30443b032')  # 替换为目标答题页面 URL

# 等待固定时间（例如 30 秒）完成扫码登录
time.sleep(30)

# 定位输入框并输入答案
question_box = driver.find_element(By.ID, 'question-input')
answer = "Python"
question_box.send_keys(answer)

# 提交答案
submit_button = driver.find_element(By.ID, 'submit-button')
submit_button.click()

#driver.quit()
