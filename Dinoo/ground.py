import pygame
from utils import load_image

class Ground:
    def __init__(self, speed=-5, width=800, height=600):
        self.image, self.rect = load_image('ground.png', -1, -1, -1)
        self.image1, self.rect1 = load_image('ground.png', -1, -1, -1)
        self.rect.bottom = height
        self.rect1.bottom = height
        self.rect1.left = self.rect.right
        self.speed = speed

    def draw(self, screen):
        screen.blit(self.image, self.rect)
        screen.blit(self.image1, self.rect1)

    def update(self):
        self.rect.left += self.speed
        self.rect1.left += self.speed

        if self.rect.right < 0:
            self.rect.left = self.rect1.right

        if self.rect1.right < 0:
            self.rect1.left = self.rect.right
