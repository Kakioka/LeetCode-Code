class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        #create defaultdict which is an empty dictionary essentially which returns whatever is in the () as the default behavior.
        mpAns = defaultdict(list)

        #iterate through each str in strs
        for str in strs:
            #join combines a list or array of some kind with whatever is typed before it as a seperator. In this case, nothing ''. (seperator).join
            #sorted(str) sorts alphabetically or in ascending order for numbers by default otherwise sorting based on some parameter
            sortedStr = ''.join(sorted(str))
            #using the SORTED string as the unique key we append the original string to the list that we specified to be created in the defaultdict step. If it's NOT unique then it is simply appended to that list. 
            mpAns[sortedStr].append(str)

        #list() returns a list of a given parameter
        #values gets the values or the lists assigned to each unique key in mpAns
        return list(mpAns.values())
        
