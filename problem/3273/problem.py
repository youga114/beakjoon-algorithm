def binary_search(target, data):
    start = 0 			# 맨 처음 위치
    end = len(data) - 1 	# 맨 마지막 위치

    while start <= end:
        mid = (start + end) // 2 # 중간값

        if data[mid] == target:
            return mid 		# target 위치 반환

        elif data[mid] > target: # target이 작으면 왼쪽을 더 탐색
            end = mid - 1
        else:                    # target이 크면 오른쪽을 더 탐색
            start = mid + 1
    return

n = int(input())
a = list(map(int, input().split(' ')))
a.sort()
x = int(input())
answer = 0

for i in range(n):
    if binary_search(x - a[i], a) != None:
        answer += 1

print(int(answer / 2))