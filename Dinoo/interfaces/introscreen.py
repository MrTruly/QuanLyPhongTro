import pygame
import sys
# from dinosaur.pteranodon import Pteranodon
from dinosaur.dino import Dino
from button import Button
from utils import *
from config import *

gamePaused = False

def introscreen():
    temp_dino = Dino(44, 47)
    temp_dino.isBlinking = True
    gameStart = False
    tutorial = "Nhấn phím [1] [2] [3] để sử dụng kỹ năng"
    gamePause = "Nhấn phím ESC hoặc P để pause game"
    temp_ground, temp_ground_rect = load_sprite_sheet(
        'ground.png', 15, 1, -1, -1, -1)
    temp_ground_rect.left = width / 20
    temp_ground_rect.bottom = height

    # Create buttons
    PLAY_BUTTON = Button('play_rect.png', pos=(width / 2, height / 2 - 100),
                         text_input="PLAY", font=font, base_color="Black", hovering_color="White")
    CHARACTER_BUTTON = Button('play_rect.png', pos=(width / 2, height / 2),
                              text_input="SKIN", font=font, base_color="Black", hovering_color="White")
    QUIT_BUTTON = Button('quit_rect.png', pos=(width / 2, height / 2 + 100),
                         text_input="QUIT", font=font, base_color="Black", hovering_color="White")

    while not gameStart:
        if pygame.display.get_surface() is None:
            print("Couldn't load display surface")
            return True
        else:
            mouse_pos = pygame.mouse.get_pos()

            for event in pygame.event.get():
                if event.type == pygame.QUIT:
                    return True
                if event.type == pygame.MOUSEBUTTONDOWN:
                    if PLAY_BUTTON.checkForInput(mouse_pos):
                        temp_dino.movement[1] = -1 * temp_dino.jumpSpeed
                        gameStart = True
                        from interfaces.gameplay import start_game_with_skin
                        start_game_with_skin(skins[selected_skin]["ingame"], skins[selected_skin]["ingame_ducking"])
                        return
                    if CHARACTER_BUTTON.checkForInput(mouse_pos):
                        from interfaces.options import options
                        options()
                        return
                    if QUIT_BUTTON.checkForInput(mouse_pos):
                        return True

        temp_dino.update()

        if pygame.display.get_surface() is not None:
            screen.fill(background_col)
            screen.blit(temp_ground[0], temp_ground_rect)
            if temp_dino.isBlinking:
                PLAY_BUTTON.changeColor(mouse_pos)
                CHARACTER_BUTTON.changeColor(mouse_pos)
                QUIT_BUTTON.changeColor(mouse_pos)

                PLAY_BUTTON.update(screen)
                CHARACTER_BUTTON.update(screen)
                QUIT_BUTTON.update(screen)

                text_surface = font.render(tutorial, True, (0, 0, 0))
                text_pause = font.render(gamePause, True, (0, 0, 0))
                text_rect = text_surface.get_rect(
                    center=(width / 2, height * 0.8))
                screen.blit(text_surface, text_rect)
                temp_dino.draw(screen)

                pygame.display.update()

            clock.tick(FPS)

    return False