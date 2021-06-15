def main():
    player_number = int(input('Input total number of players: '))
    player_file = open('score.txt', 'w')

    for count in range (1, player_number+1):
        player_name = str(input('Input player name: '))
        player_score = int(input('Input player #' + str(count) + ' score:' ))
        player_file.write(player_name + '\n')
        player_file.write(str(player_score) + '\n')
    
    player_file.close()

main()