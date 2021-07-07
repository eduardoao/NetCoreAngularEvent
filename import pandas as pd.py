#import pandas as pd
import requests
from bs4 import BeautifulSoup

req = requests.get('https://www.udemy.com/course/angular-dotnetcore-efcore/')
if req.status_code == 200:
    print('Requisição bem sucedida!')
    content = req.content    

soup = BeautifulSoup(content, 'html5lib')
div = soup.find(name='course-curriculum')

tags = soup.findAll("span", {"class": "section--section-title--8blTh"})
for tag in tags:
        print(tag.getText())
